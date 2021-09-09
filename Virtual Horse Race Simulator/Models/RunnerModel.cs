using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHorseRaceSimulator.Models
{
    /// <summary>
    /// Model for Horse Race Runners
    /// </summary>
    public class RunnerModel
    {
        /// <summary>
        /// Name of the runner
        /// </summary>
        public string RunnerName { get; set; }
        /// <summary>
        /// Odds for the runner
        /// </summary>
        public decimal RunnerOdds { get; set; }
    }
}
