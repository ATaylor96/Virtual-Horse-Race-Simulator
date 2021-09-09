using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualHorseRaceSimulator.Models;

namespace VirtualHorseRaceSimulator
{
    public partial class MainForm : Form
    {
        // List of runners in this horse race
        private List<RunnerModel> runnersList = new List<RunnerModel>();

        private decimal raceMargin = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void addRunnerButton_Click(object sender, EventArgs e)
        {
            // Check if runner name and odds are valid
            if (VerifyHorseValues())
            {
                // Add runner to runnersList and runnersListView
                AddRunner();

                // Reset add runner controls
                horseNameTextBox.Text = "";
                oddsTextBox1.Text = "";
                oddsTextBox2.Text = "";

                // Check if race is valid and enabling raceButton if it is.
                runRaceButton.Enabled = ValidateRace();
                unitTestButton.Enabled = ValidateRace();

                runRaceButton.Text = $"Run Race\nMargin = { raceMargin }";
            }
        }

        private void AddRunner()
        {
            // Create a new runner model using data from the form
            RunnerModel runner = new RunnerModel
            {
                RunnerName = horseNameTextBox.Text,
                RunnerOdds = Convert.ToDecimal((Convert.ToDecimal(oddsTextBox1.Text) / (Convert.ToDecimal(oddsTextBox2.Text)) + 1))
            };

            // Adds newly created runner to the model list
            runnersList.Add(runner);

            // Using form and model data create a new listviewitem
            ListViewItem item = new ListViewItem
            {
                Text = runner.RunnerName
            };
            item.SubItems.Add($"{ oddsTextBox1.Text } / { oddsTextBox2.Text }");
            item.Tag = runner;

            // Add new item to the listview for visual feedback
            runnersListView.Items.Add(item);
        }

        /// <summary>
        /// Make sure the race setup is valid for a race - check for correct runner count and race margin.
        /// </summary>
        /// <returns></returns>
        private bool ValidateRace()
        {
            bool isValidRace = false;

            raceMargin = 0;

            // Check the runners count to see if it's within range
            if (runnersList.Count >= 4 && runnersList.Count <= 16)
            {
                foreach (var runner in runnersList)
                {
                    raceMargin += 100 / runner.RunnerOdds;
                }

                // Calculate the race margin value
                raceMargin = decimal.Round(raceMargin, 2, MidpointRounding.AwayFromZero);

                // Check if race margin is within range
                if (raceMargin >= 110 && raceMargin <= 140)
                {
                    isValidRace = true;
                }
            }

            return isValidRace;
        }

        /// <summary>
        /// Verify that the input values for new runners is valid
        /// </summary>
        /// <returns></returns>
        private bool VerifyHorseValues()
        {
            // Check if runner name is correct length
            if (horseNameTextBox.Text.Length <= 0 || horseNameTextBox.Text.Length > 18)
            {
                MessageBox.Show("Please make sure the horses name is between 1 and 18 characters long (including spaces).");
                return false;
            }

            // Check if horse name contains any digits
            if (horseNameTextBox.Text.Any(char.IsDigit) || horseNameTextBox.Text.Any(char.IsPunctuation))
            {
                MessageBox.Show("Please make sure horses name only contains A-Z characters and spaces.");
                return false;
            }

            // Make sure odds are digits and that they have values
            if (!oddsTextBox1.Text.Any(char.IsDigit) || !oddsTextBox2.Text.Any(char.IsDigit) || string.IsNullOrEmpty(oddsTextBox1.Text) || string.IsNullOrEmpty(oddsTextBox2.Text))
            {
                MessageBox.Show("Please make sure odds only contain numerical values.");
                return false;
            }

            // Check if odds are greater than 1
            if (Convert.ToInt32(oddsTextBox1.Text) < 1 || Convert.ToInt32(oddsTextBox2.Text) < 1)
            {
                MessageBox.Show("Please make sure odds are greater than 1.");
                return false;
            }

            // If all is okay return true
            return true;
        }

        private void deleteRunnerButton_Click(object sender, EventArgs e)
        {
            // Check every selected item to see if the runners model list contains the item.
            // If it does remove it from the mode list and if it doesn't remove from listview anyway.
            foreach (ListViewItem item in runnersListView.SelectedItems)
            {
                if (runnersList.Contains((RunnerModel)item.Tag))
                    runnersList.Remove((RunnerModel)item.Tag);

                runnersListView.Items.Remove(item);

                // Validate race again
                runRaceButton.Enabled = ValidateRace();
                unitTestButton.Enabled = ValidateRace();

                runRaceButton.Text = $"Run Race\nMargin = { raceMargin }";
            }
        }

        private void runRaceButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            MessageBox.Show($"Winner is: { FindWinner(rnd) }");
        }

        private RunnerModel FindWinner(Random rnd)
        {
            // Create new random number between 0 and 100
            decimal random = Decimal.Round(Convert.ToDecimal(rnd.NextDouble() * 100), 2, MidpointRounding.AwayFromZero);

            decimal currentOdds = 0;

            // Sort runners list by odds by lowest first
            runnersList.Sort((x, y) => x.RunnerOdds.CompareTo(y.RunnerOdds));

            // For every runner in list set the current odds and check if random number is less than or equal to the random number, if yes break out of foreach and show winner.
            foreach (RunnerModel runner in runnersList)
            {
                currentOdds += decimal.Round(((100 / runner.RunnerOdds) / raceMargin) * 100, 2, MidpointRounding.AwayFromZero);

                if (random <= currentOdds)
                    return runner;
            }
            return null;
        }

        private void unitTestButton_Click(object sender, EventArgs e)
        {
            // Set iterations and results text
            const int iterations = 1000000;
            string results = $"Results over { iterations } iterations.{ Environment.NewLine }{ Environment.NewLine }";

            // Sort runners list from lowest odds to highest
            runnersList.Sort((x, y) => x.RunnerOdds.CompareTo(y.RunnerOdds));

            List<RunnerModel> raceWinners = new List<RunnerModel>();
            Random rnd = new Random();
            for (int i = 0; i < iterations; i++)
            {
                raceWinners.Add(FindWinner(rnd));
            }
            
            results += $"Total races: { raceWinners.Count }{ Environment.NewLine }{ Environment.NewLine }";

            foreach (RunnerModel runner in runnersList)
            {
                int count = 0;
                decimal odds = decimal.Round(((100 / runner.RunnerOdds) / raceMargin) * 100, 2, MidpointRounding.AwayFromZero);

                foreach (RunnerModel r in raceWinners)
                    if (runner == r)
                        count++;

                results += $"{ runner.RunnerName } ({ odds }%) won { count } races. { Environment.NewLine }";

                decimal minRange = decimal.Round(((odds / 100) * iterations) - ((decimal)0.02 * iterations));
                decimal maxRange = decimal.Round(((odds / 100) * iterations) + ((decimal)0.02 * iterations));

                if (count >= minRange && count <= maxRange)
                    results += $"Results within range ({ minRange } to { maxRange }).";
                else
                    results += $"Results not within range ({ minRange } to { maxRange }).";

                results += Environment.NewLine + Environment.NewLine;
            }

            MessageBox.Show(results);
        }
    }
}
