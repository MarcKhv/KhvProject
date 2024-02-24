using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRecordSystem
{
    public partial class StudentRecordSystem : Form
    {
        private int progressBarMaxValue = 100; // Set the maximum value of the progress bar
        private int progressBarStep = 50;       // Set the step value for each increment
        private int progressBarCurrentValue = 0; //
        public StudentRecordSystem()
        {
            InitializeComponent();
            autoswitchtimer.Start();
        }

        private void autoswitchtimer_Tick(object sender, EventArgs e)
        {
            // Increment the progress bar value
            progressBarCurrentValue += progressBarStep;

            // Ensure the current value is within the valid range
            progressBarCurrentValue = Math.Min(progressBarCurrentValue, progressBarMaxValue);

            // Update the progress bar
            progressBar1.Value = progressBarCurrentValue;

            // Check if 3 seconds have passed
            if (progressBarCurrentValue >= progressBarMaxValue)
            {
                // Stop the timer to prevent it from triggering again
                autoswitchtimer.Stop();

                // Create an instance of Form2
                AddGradeForm switchform = new AddGradeForm();

                // Hide the current form (Form1)
                this.Hide();

                // Show AddGradeForm
                switchform.Show();
            }
        }
    }

}
