
using System;
using System.Windows.Forms;

namespace MachineProblemWInForm
{
    public partial class UsageOfCaretSymbol : Form
    {
        // Constant value of pi as required
        private const double PI = 3.1416;

        public UsageOfCaretSymbol()
        {
            InitializeComponent();

            // Make result textboxes read-only
            exponentresulttxt.ReadOnly = true;
            areatxt.ReadOnly = true;
            circumferencetxt.ReadOnly = true;
            diametertxt.ReadOnly = true;
        }

        // Calculate exponent using the caret button
        private void equalbtn_Click(object sender, EventArgs e)
        {
            double baseNumber;
            double power;

            if (!double.TryParse(basetxt.Text, out baseNumber) ||
                !double.TryParse(powertxt.Text, out power))
            {
                MessageBox.Show(
                    "Please enter a valid Base and Power.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Math.Pow performs exponentiation in C#
            double result = Math.Pow(baseNumber, power);

            exponentresulttxt.Text = result.ToString("F2");
        }

        // Calculate circle area: A = pi * r^2
        private void areabtn_Click(object sender, EventArgs e)
        {
            double radius;

            if (!double.TryParse(radiustxt.Text, out radius))
            {
                MessageBox.Show("Please enter a valid Radius.");
                return;
            }

            if (radius < 0)
            {
                MessageBox.Show("Radius cannot be negative.");
                return;
            }

            double area = PI * radius * radius;

            areatxt.Text = area.ToString("F2");
        }

        // Calculate circumference: C = 2 * pi * r
        private void circumferencebtn_Click(object sender, EventArgs e)
        {
            double radius;

            if (!double.TryParse(radiustxt.Text, out radius))
            {
                MessageBox.Show("Please enter a valid Radius.");
                return;
            }

            if (radius < 0)
            {
                MessageBox.Show("Radius cannot be negative.");
                return;
            }

            double circumference = 2 * PI * radius;

            circumferencetxt.Text = circumference.ToString("F2");
        }

        // Calculate diameter: D = 2 * r
        private void diameter_Click(object sender, EventArgs e)
        {
            double radius;

            if (!double.TryParse(radiustxt.Text, out radius))
            {
                MessageBox.Show("Please enter a valid Radius.");
                return;
            }

            if (radius < 0)
            {
                MessageBox.Show("Radius cannot be negative.");
                return;
            }

            double diameter = 2 * radius;

            diametertxt.Text = diameter.ToString("F2");
        }

        // Clear all input and result textboxes
        private void clearbtn_Click(object sender, EventArgs e)
        {
            basetxt.Clear();
            powertxt.Clear();
            exponentresulttxt.Clear();

            radiustxt.Clear();
            areatxt.Clear();
            circumferencetxt.Clear();
            diametertxt.Clear();

            basetxt.Focus();
        }

        // Exit the application
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Unused events
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void basetxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void powertxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void exponentresulttxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void radiustxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void areatxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void circumferencetxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void diametertxt_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
