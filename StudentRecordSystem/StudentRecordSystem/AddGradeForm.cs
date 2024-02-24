using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentRecordSystem
{
    public partial class AddGradeForm : Form
    {
        List<double> grades = new List<double>();
        List<double> credithoura = new List<double>();
        List<double> totalA = new List<double>();
        double average;
        public AddGradeForm()
        {
            InitializeComponent();
        }

        public void addtolistview()
        {
            if (gradesmasktextbox.MaskCompleted && credithoursmaskedbox.MaskCompleted)
            {
                double grade = 0;
                double marks = Convert.ToDouble(gradesmasktextbox.Text);
                double score = Convert.ToDouble(credithoursmaskedbox.Text);
                string usg = "";

                switch (marks)
                {
                    case double n when (n >= 80 && n <= 100):
                        grade = score * 4.0;
                        usg = "A";
                        break;
                    case double n when (n >= 75 && n <= 79):
                        grade = score * 3.5;
                        usg = "B+";
                        break;
                    case double n when (n >= 70 && n <= 74):
                        grade = score * 3.0;
                        usg = "B";
                        break;
                    case double n when (n >= 65 && n <= 69):
                        grade = score * 2.5;
                        usg = "C+";
                        break;
                    case double n when (n >= 60 && n <= 64):
                        grade = score * 2.0;
                        usg = "C";
                        break;
                    case double n when (n >= 55 && n <= 59):
                        grade = grade * 1.5;
                        usg = "D+";
                        break;
                    case double n when (n >= 50 && n <= 54):
                        grade = grade * 1.0;
                        usg = "D";
                        break;
                    case double n when (n >= 0 && n <= 49):
                        grade = grade * 0.0;
                        usg = "F";
                        break;
                    default:
                        Console.WriteLine("Invalid marks entered");
                        break;
                }

                grades.Add(grade);

                double credhour = Convert.ToDouble(credithoursmaskedbox.Text);
                credithoura.Add(credhour);

                ListViewItem item = new ListViewItem(Convert.ToString(gradesmasktextbox.Text));
                item.SubItems.Add(credithoursmaskedbox.Text);
                item.SubItems.Add(usg);
                listView.Items.Add(item);
                gradesmasktextbox.Clear();
                credithoursmaskedbox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid on each field");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addtolistview();       
        }

        public void calculateAverage()
        {
            if (grades.Count > 0)
            {
                average = grades.Sum() / credithoura.Sum();
                MessageBox.Show($"Average Grade: {average:F2}");
            }
            else
            {
                MessageBox.Show("No grades available to calculate average.");
            }
        }

        private void toolStripMenuCalcAverage_Click(object sender, EventArgs e)
        {
            calculateAverage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedGrade = listView.SelectedItems[0];
                double grade = Convert.ToDouble(selectedGrade.Text);

                grades.Remove(grade);
                listView.Items.Remove(selectedGrade);
            }
            else
            {
                MessageBox.Show("Please select a grade to remove.");
            }
        }

        public void cleargrades()
        {
            listView.Items.Clear();
            grades.Clear();
            credithoura.Clear();
        }

        private void toolStripMenuClrGrade_Click(object sender, EventArgs e)
        {
            cleargrades();
        }

        private void calculateAverageMenuItem_Click(object sender, EventArgs e)
        {
            double tot = totalA.Average();

            MessageBox.Show($"Your total CGPA is: {tot}", "CGPA Information");

            cleargrades();
        }

        private void clearGradesMenuItem_Click(object sender, EventArgs e)
        {
            cleargrades();
        }

        private void toolStripMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Override the OnFormClosing event to handle the default close button
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancel the close operation
                }
            }
        }

        private void toolStripMenuAddGrade_Click(object sender, EventArgs e)
        {
            cleargrades();
            string formattedAverage = average.ToString("F2");
            
            totalA.Add(Convert.ToDouble(formattedAverage));

            ListViewItem item = new ListViewItem();
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add(Convert.ToString(formattedAverage));
            item.SubItems.Add("");
            listView.Items.Add(item);
        }

        private void helpbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Letter Grade A --> Marks  80 – 100 = 4.0  " +
                "\r\nLetter Grade B+ --> Marks  75 – 79  = 3.5   " +
                "\r\nLetter Grade B --> Marks  70 – 74  = 3.0  " +
                "\r\nLetter Grade C+ --> Marks  65 – 69 = 2.5  " +
                "\r\nLetter Grade C --> Marks  60 – 64 = 2.0  " +
                "\r\nLetter Grade D+ --> Marks  55 – 59 = 1.5  " +
                "\r\nLetter Grade D --> Marks  50 – 54  = 1.0  " +
                "\r\nLetter Grade F --> Marks  0 – 49  = 0.0  ");
        }

        private void credithourkeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (ASCII code 13)
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Calculate the sum and display it
                addtolistview();

                // Suppress the Enter key to prevent a newline character in the textbox
                e.Handled = true;
            }
        }
    }
}
