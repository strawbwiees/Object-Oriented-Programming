
using System;
using System.Windows.Forms;

namespace MachineProblemWInForm
{
    public partial class ComputeNetAmount : Form
    {
        public ComputeNetAmount()
        {
            InitializeComponent();

            // Output textboxes cannot be edited by the user
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
        }

        // Calculate Sub-Total, Discount, and Net Amount
        private void calculatebtn_Click(object sender, EventArgs e)
        {
            double productAmount;
            int quantity;

            // Validate Product Amount
            if (!double.TryParse(textBox1.Text, out productAmount) ||
                !int.TryParse(textBox2.Text, out quantity))
            {
                MessageBox.Show(
                    "Please enter a valid Product Amount and Quantity.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validate input values
            if (productAmount < 0 || quantity < 0)
            {
                MessageBox.Show(
                    "Product Amount and Quantity cannot be negative.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Compute Sub-Total
            double subTotal = productAmount * quantity;

            // Compute 20% Discount
            double discountAmount = subTotal * 0.20;

            // Compute Net Amount
            double netAmount = subTotal - discountAmount;

            // Display results
            textBox3.Text = subTotal.ToString("0.00");
            textBox4.Text = discountAmount.ToString("0.00");
            textBox5.Text = netAmount.ToString("0.00");
        }

        // Clear all textboxes
        private void clearbtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            textBox1.Focus();
        }

        // Close the application
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
