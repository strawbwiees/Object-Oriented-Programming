
using System;
using System.Windows.Forms;
using System.Drawing;

namespace MachineProblemWInForm
{
    public partial class GradeComputation : Form
    {
        public GradeComputation()
        {
            InitializeComponent();

            // Disable the Semestral Grade textbox
            textBox4.Enabled = false;

            // Remove Minimize, Maximize, and Close buttons
            this.ControlBox = false;

            // Set initial status labels
            label5.Text = "Status:";
            label6.Text = "";
            label6.ForeColor = Color.Black;
        }

        private void computebtn_Click(object sender, EventArgs e)
        {
            double prelim, midterm, finalGrade, semestralGrade;

            // Validate the input grades
            if (!double.TryParse(textBox1.Text, out prelim) ||
                !double.TryParse(textBox2.Text, out midterm) ||
                !double.TryParse(textBox3.Text, out finalGrade))
            {
                MessageBox.Show(
                    "Please enter valid grades for Prelim, Midterm, and Final.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Check if grades are within the valid range
            if (prelim < 0 || prelim > 100 ||
                midterm < 0 || midterm > 100 ||
                finalGrade < 0 || finalGrade > 100)
            {
                MessageBox.Show(
                    "Grades must be between 0 and 100.",
                    "Invalid Grade",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Compute the semestral grade
            semestralGrade =
                (prelim * 0.25) +
                (midterm * 0.25) +
                (finalGrade * 0.50);

            // Display the semestral grade
            textBox4.Text = semestralGrade.ToString("0.00");

            // Determine pass or fail
            label5.Text = "Status:";

            if (semestralGrade >= 75)
            {
                label6.Text = "PASSED";
                label6.ForeColor = Color.Green;
            }
            else
            {
                label6.Text = "FAILED";
                label6.ForeColor = Color.Red;
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            // Clear all grade textboxes
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            // Reset status labels
            label5.Text = "Status:";
            label6.Text = "";
            label6.ForeColor = Color.Black;

            // Return focus to the first textbox
            textBox1.Focus();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void GradeComputation_Load(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
    }
}
