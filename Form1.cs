
using System;
using System.Windows.Forms;

namespace MachineProblemWInForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Make the result textbox read-only
            resulttxt.ReadOnly = true;
        }

        // Add a calculation to the history list
        private void AddToHistory(
            double num1,
            double num2,
            string operation,
            double result)
        {
            string entry = $"{num1:0.##} {operation} {num2:0.##} = {result:0.##}";

            // Display the newest calculation at the top
            historyListBox.Items.Insert(0, entry);
        }

        // Common method for mathematical operations
        private void Calculate(string operation)
        {
            double num1, num2, result;

            // Validate inputs
            if (!double.TryParse(argument1txt.Text, out num1) ||
                !double.TryParse(argument2txt.Text, out num2))
            {
                MessageBox.Show(
                    "Please enter valid numbers in Argument 1 and Argument 2.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }

                    result = num1 / num2;
                    break;

                case "MOD":
                    if (num2 == 0)
                    {
                        MessageBox.Show(
                            "Cannot get the remainder when dividing by zero.");
                        return;
                    }

                    result = num1 % num2;
                    break;

                case "\\":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }

                    // Integer division: remove the fractional part
                    result = Math.Truncate(num1 / num2);
                    break;

                default:
                    return;
            }

            // Display the result
            resulttxt.Text = result.ToString("0.##");

            // Save the successful calculation to history
            AddToHistory(num1, num2, operation, result);
        }

        // Addition
        private void additionbtn_Click(object sender, EventArgs e)
        {
            Calculate("+");
        }

        // Subtraction
        private void subtractionbtn_Click(object sender, EventArgs e)
        {
            Calculate("-");
        }

        // Multiplication
        private void multiplicationbtn_Click(object sender, EventArgs e)
        {
            Calculate("*");
        }

        // Division
        private void divisionbtn_Click(object sender, EventArgs e)
        {
            Calculate("/");
        }

        // Modulo (remainder)
        private void modulobtn_Click(object sender, EventArgs e)
        {
            Calculate("MOD");
        }

        // Integer division (\ in VB.NET)
        private void backslashbtn_Click(object sender, EventArgs e)
        {
            Calculate("\\");
        }

        // Clear the input and result textboxes only
        private void clearbtn_Click(object sender, EventArgs e)
        {
            argument1txt.Clear();
            argument2txt.Clear();
            resulttxt.Clear();

            // Keep the calculation history
            argument1txt.Focus();
        }

        // Clear the entire calculation history
        private void clearHistorybtn_Click(object sender, EventArgs e)
        {
            historyListBox.Items.Clear();
        }

        // Close the application
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Label and GroupBox events
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void historyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
