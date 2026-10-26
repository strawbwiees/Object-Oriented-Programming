
using System;
using System.Windows.Forms;

namespace MachineProblemWInForm
{
    public partial class ComputeNetAmount : Form
    {
        private const double DISCOUNT_RATE = 0.20;

        public ComputeNetAmount()
        {
            InitializeComponent();

            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;

            // Receipt formatting
            listBox1.Font = new System.Drawing.Font(
                "Consolas", 10, System.Drawing.FontStyle.Regular);

            listBox1.HorizontalScrollbar = true;
        }

        // Calculate and generate receipt
        private void calculatebtn_Click(object sender, EventArgs e)
        {
            double productAmount;
            int quantity;

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

            //invalid
            if (productAmount < 0 || quantity <= 0)
            {
                MessageBox.Show(
                    "Product Amount cannot be negative and Quantity must be greater than zero.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }


            double subTotal = productAmount * quantity;
            double discountAmount = subTotal * DISCOUNT_RATE;
            double netAmount = subTotal - discountAmount;

            // Display computed values
            textBox3.Text = subTotal.ToString("0.00");
            textBox4.Text = discountAmount.ToString("0.00");
            textBox5.Text = netAmount.ToString("0.00");

            // Generate receipt
            GenerateReceipt(
                productAmount,
                quantity,
                subTotal,
                discountAmount,
                netAmount
            );
        }

        // format
        private void GenerateReceipt(
            double productAmount,
            int quantity,
            double subTotal,
            double discountAmount,
            double netAmount)
        {
            listBox1.Items.Clear();

            string line = "================================";
            string divider = "--------------------------------";

            listBox1.Items.Add("          STORE RECEIPT");
            listBox1.Items.Add("       COMPUTING NET AMOUNT");
            listBox1.Items.Add(line);
            listBox1.Items.Add("Date: " + DateTime.Now.ToString("MM/dd/yyyy"));
            listBox1.Items.Add("Time: " + DateTime.Now.ToString("hh:mm tt"));
            listBox1.Items.Add("Receipt No: " +
                DateTime.Now.ToString("yyyyMMddHHmmss"));
            listBox1.Items.Add(line);
            listBox1.Items.Add("ITEM           QTY     AMOUNT");
            listBox1.Items.Add(divider);

            listBox1.Items.Add("Product        " +
                quantity.ToString().PadLeft(3) + "     " +
                productAmount.ToString("0.00").PadLeft(8));

            listBox1.Items.Add(divider);
            listBox1.Items.Add(
                "Unit Price:       " + productAmount.ToString("0.00"));

            listBox1.Items.Add(
                "Quantity:         " + quantity);

            listBox1.Items.Add(divider);
            listBox1.Items.Add(
                "Subtotal:       " + subTotal.ToString("0.00").PadLeft(10));

            listBox1.Items.Add(
                "Discount (20%): " + discountAmount.ToString("0.00").PadLeft(10));

            listBox1.Items.Add(line);
            listBox1.Items.Add(
                "TOTAL DUE:      " + netAmount.ToString("0.00").PadLeft(10));

            listBox1.Items.Add(line);
            listBox1.Items.Add("       THANK YOU FOR SHOPPING!");
            listBox1.Items.Add("          PLEASE COME AGAIN");
            listBox1.Items.Add(line);

            // Scroll to the top of the receipt
            listBox1.TopIndex = 0;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            listBox1.Items.Clear();

            textBox1.Focus();
        }

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

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ComputeNetAmount_Load(object sender, EventArgs e)
        {

        }
    }
}
