
namespace VirtualHorseRaceSimulator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addRunnerGroupBox = new System.Windows.Forms.GroupBox();
            this.addRunnerButton = new System.Windows.Forms.Button();
            this.oddsTextBox2 = new System.Windows.Forms.TextBox();
            this.oddsTextBox1 = new System.Windows.Forms.TextBox();
            this.horseNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.oddsLabel = new System.Windows.Forms.Label();
            this.horseNameLabel = new System.Windows.Forms.Label();
            this.runRaceButton = new System.Windows.Forms.Button();
            this.deleteRunnerButton = new System.Windows.Forms.Button();
            this.runnersListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oddsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitTestButton = new System.Windows.Forms.Button();
            this.addRunnerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addRunnerGroupBox
            // 
            this.addRunnerGroupBox.Controls.Add(this.addRunnerButton);
            this.addRunnerGroupBox.Controls.Add(this.oddsTextBox2);
            this.addRunnerGroupBox.Controls.Add(this.oddsTextBox1);
            this.addRunnerGroupBox.Controls.Add(this.horseNameTextBox);
            this.addRunnerGroupBox.Controls.Add(this.label3);
            this.addRunnerGroupBox.Controls.Add(this.oddsLabel);
            this.addRunnerGroupBox.Controls.Add(this.horseNameLabel);
            this.addRunnerGroupBox.Location = new System.Drawing.Point(12, 12);
            this.addRunnerGroupBox.Name = "addRunnerGroupBox";
            this.addRunnerGroupBox.Size = new System.Drawing.Size(246, 123);
            this.addRunnerGroupBox.TabIndex = 1;
            this.addRunnerGroupBox.TabStop = false;
            this.addRunnerGroupBox.Text = "Add Runner";
            // 
            // addRunnerButton
            // 
            this.addRunnerButton.Location = new System.Drawing.Point(133, 74);
            this.addRunnerButton.Name = "addRunnerButton";
            this.addRunnerButton.Size = new System.Drawing.Size(100, 36);
            this.addRunnerButton.TabIndex = 2;
            this.addRunnerButton.Text = "Add Runner";
            this.addRunnerButton.UseVisualStyleBackColor = true;
            this.addRunnerButton.Click += new System.EventHandler(this.addRunnerButton_Click);
            // 
            // oddsTextBox2
            // 
            this.oddsTextBox2.Location = new System.Drawing.Point(76, 90);
            this.oddsTextBox2.Name = "oddsTextBox2";
            this.oddsTextBox2.Size = new System.Drawing.Size(43, 20);
            this.oddsTextBox2.TabIndex = 7;
            // 
            // oddsTextBox1
            // 
            this.oddsTextBox1.Location = new System.Drawing.Point(9, 90);
            this.oddsTextBox1.Name = "oddsTextBox1";
            this.oddsTextBox1.Size = new System.Drawing.Size(43, 20);
            this.oddsTextBox1.TabIndex = 6;
            // 
            // horseNameTextBox
            // 
            this.horseNameTextBox.Location = new System.Drawing.Point(9, 42);
            this.horseNameTextBox.Name = "horseNameTextBox";
            this.horseNameTextBox.Size = new System.Drawing.Size(224, 20);
            this.horseNameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "/";
            // 
            // oddsLabel
            // 
            this.oddsLabel.AutoSize = true;
            this.oddsLabel.Location = new System.Drawing.Point(6, 74);
            this.oddsLabel.Name = "oddsLabel";
            this.oddsLabel.Size = new System.Drawing.Size(87, 13);
            this.oddsLabel.TabIndex = 3;
            this.oddsLabel.Text = "Odds (Fractional)";
            // 
            // horseNameLabel
            // 
            this.horseNameLabel.AutoSize = true;
            this.horseNameLabel.Location = new System.Drawing.Point(6, 25);
            this.horseNameLabel.Name = "horseNameLabel";
            this.horseNameLabel.Size = new System.Drawing.Size(66, 13);
            this.horseNameLabel.TabIndex = 2;
            this.horseNameLabel.Text = "Horse Name";
            // 
            // runRaceButton
            // 
            this.runRaceButton.Enabled = false;
            this.runRaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runRaceButton.Location = new System.Drawing.Point(12, 183);
            this.runRaceButton.Name = "runRaceButton";
            this.runRaceButton.Size = new System.Drawing.Size(246, 91);
            this.runRaceButton.TabIndex = 8;
            this.runRaceButton.Text = "Run Race";
            this.runRaceButton.UseVisualStyleBackColor = true;
            this.runRaceButton.Click += new System.EventHandler(this.runRaceButton_Click);
            // 
            // deleteRunnerButton
            // 
            this.deleteRunnerButton.Location = new System.Drawing.Point(12, 141);
            this.deleteRunnerButton.Name = "deleteRunnerButton";
            this.deleteRunnerButton.Size = new System.Drawing.Size(246, 36);
            this.deleteRunnerButton.TabIndex = 8;
            this.deleteRunnerButton.Text = "Delete Selected";
            this.deleteRunnerButton.UseVisualStyleBackColor = true;
            this.deleteRunnerButton.Click += new System.EventHandler(this.deleteRunnerButton_Click);
            // 
            // runnersListView
            // 
            this.runnersListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.runnersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.oddsColumn});
            this.runnersListView.FullRowSelect = true;
            this.runnersListView.HideSelection = false;
            this.runnersListView.Location = new System.Drawing.Point(264, 12);
            this.runnersListView.Name = "runnersListView";
            this.runnersListView.Size = new System.Drawing.Size(182, 300);
            this.runnersListView.TabIndex = 9;
            this.runnersListView.UseCompatibleStateImageBehavior = false;
            this.runnersListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Runner Name";
            this.nameColumn.Width = 114;
            // 
            // oddsColumn
            // 
            this.oddsColumn.Text = "Odds";
            // 
            // unitTestButton
            // 
            this.unitTestButton.Enabled = false;
            this.unitTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitTestButton.Location = new System.Drawing.Point(12, 280);
            this.unitTestButton.Name = "unitTestButton";
            this.unitTestButton.Size = new System.Drawing.Size(246, 32);
            this.unitTestButton.TabIndex = 10;
            this.unitTestButton.Text = "Unit Test";
            this.unitTestButton.UseVisualStyleBackColor = true;
            this.unitTestButton.Click += new System.EventHandler(this.unitTestButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 324);
            this.Controls.Add(this.unitTestButton);
            this.Controls.Add(this.runnersListView);
            this.Controls.Add(this.deleteRunnerButton);
            this.Controls.Add(this.runRaceButton);
            this.Controls.Add(this.addRunnerGroupBox);
            this.MaximumSize = new System.Drawing.Size(474, 363);
            this.MinimumSize = new System.Drawing.Size(474, 363);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Horse Race Simulator";
            this.addRunnerGroupBox.ResumeLayout(false);
            this.addRunnerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox addRunnerGroupBox;
        private System.Windows.Forms.Button addRunnerButton;
        private System.Windows.Forms.TextBox oddsTextBox2;
        private System.Windows.Forms.TextBox oddsTextBox1;
        private System.Windows.Forms.TextBox horseNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label oddsLabel;
        private System.Windows.Forms.Label horseNameLabel;
        private System.Windows.Forms.Button runRaceButton;
        private System.Windows.Forms.Button deleteRunnerButton;
        private System.Windows.Forms.ListView runnersListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader oddsColumn;
        private System.Windows.Forms.Button unitTestButton;
    }
}