using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MachineProblemWInForm
{
    public partial class MachineProblem5 : Form
    {
        public MachineProblem5()
        {
            InitializeComponent();
        }

        // ---------- Helpers ----------
        private double GetPizzaPrice()
        {
            double price = 0;
            if (SizeSmallradioButton1.Checked) price = 100;
            else if (SizeMediumradioButton2.Checked) price = 150;
            else if (SizeLargeradioButton3.Checked) price = 200;

            if (CrustTypeThickradioButton5.Checked) price += price * 0.5;   // thick = +50%
            return price;
        }

        private int CountToppings()
        {
            int n = 0;
            if (ExtraCheesecheckBox1.Checked) n++;
            if (MushroomcheckBox2.Checked) n++;
            if (OlivescheckBox3.Checked) n++;
            if (OnionscheckBox4.Checked) n++;
            if (PepperscheckBox5.Checked) n++;
            if (TomatoescheckBox6.Checked) n++;
            return n;
        }

        private double GetDrinkPrice()
        {
            if (DrinksSoftdrinkradioButton6.Checked) return 20;
            if (DrinkFruitjuiceradioButton7.Checked) return 15;
            if (DrinkCoffeeradioButton8.Checked) return 25;
            return 0;
        }

        private System.Windows.Forms.Timer clock = new System.Windows.Forms.Timer();
        private void UpdateClock(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy") + "      " + DateTime.Now.ToString("h:mm:ss tt");
        }

        // Pink themed message box with an OK button (height adjusts to the text)
        private void PinkBox(string text, string caption)
        {
            Color pink = Color.FromArgb(219, 112, 147);
            Font font = new Font("Century Gothic", 10, FontStyle.Bold);
            int h = TextRenderer.MeasureText(text, font, new Size(300, 0), TextFormatFlags.WordBreak).Height;

            Form f = new Form();
            f.Text = caption;
            f.ClientSize = new Size(340, h + 90);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.FormBorderStyle = FormBorderStyle.FixedDialog;
            f.MaximizeBox = false;
            f.MinimizeBox = false;
            f.BackColor = Color.FromArgb(255, 240, 245);

            Label lbl = new Label();
            lbl.Text = text;
            lbl.Font = font;
            lbl.ForeColor = pink;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.SetBounds(20, 15, 300, h + 10);
            f.Controls.Add(lbl);

            System.Windows.Forms.Button b = new System.Windows.Forms.Button();
            b.Text = "OK";
            b.DialogResult = DialogResult.OK;
            b.FlatStyle = FlatStyle.Flat;
            b.BackColor = pink;
            b.ForeColor = Color.White;
            b.Font = font;
            b.SetBounds(130, h + 45, 80, 32);
            f.Controls.Add(b);

            f.AcceptButton = b;
            f.ShowDialog();
        }

        // ---------- Buttons ----------
        private void btnBuildPizza_Click(object sender, EventArgs e)
        {
            if (GetPizzaPrice() == 0)
            {
                PinkBox("Please select a size and crust type.", "Your Pizza");
                return;
            }

            string order = "";

            if (DineInradioButton9.Checked) order += "Dine-In" + Environment.NewLine;
            else if (TakeOutradioButton10.Checked) order += "Take-Out" + Environment.NewLine;

            if (SizeSmallradioButton1.Checked) order += "Small Pizza" + Environment.NewLine;
            else if (SizeMediumradioButton2.Checked) order += "Medium Pizza" + Environment.NewLine;
            else if (SizeLargeradioButton3.Checked) order += "Large Pizza" + Environment.NewLine;

            if (CrustTypeThinradioButton4.Checked) order += "Thin Crust" + Environment.NewLine;
            else if (CrustTypeThickradioButton5.Checked) order += "Thick Crust" + Environment.NewLine;

            if (DrinksSoftdrinkradioButton6.Checked) order += "Soft Drinks" + Environment.NewLine;
            else if (DrinkFruitjuiceradioButton7.Checked) order += "Fruit Juice" + Environment.NewLine;
            else if (DrinkCoffeeradioButton8.Checked) order += "Coffee/Chocolate" + Environment.NewLine;

            if (ExtraCheesecheckBox1.Checked) order += "Extra Cheese" + Environment.NewLine;
            if (MushroomcheckBox2.Checked) order += "Mushrooms" + Environment.NewLine;
            if (OlivescheckBox3.Checked) order += "Black Olives" + Environment.NewLine;
            if (OnionscheckBox4.Checked) order += "Onions" + Environment.NewLine;
            if (PepperscheckBox5.Checked) order += "Green Peppers" + Environment.NewLine;
            if (TomatoescheckBox6.Checked) order += "Tomatoes" + Environment.NewLine;

            PinkBox(order, "Your Pizza");
        }

        private void btnClearToppings_Click(object sender, EventArgs e)
        {
            ExtraCheesecheckBox1.Checked = false;
            MushroomcheckBox2.Checked = false;
            OlivescheckBox3.Checked = false;
            OnionscheckBox4.Checked = false;
            PepperscheckBox5.Checked = false;
            TomatoescheckBox6.Checked = false;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double pizza = GetPizzaPrice();

            if (pizza == 0)
            {
                PinkBox("Please select a size and crust type.", "Compute");
                return;
            }

            double toppings = CountToppings() * 10;
            double drinks = GetDrinkPrice();

            textBox1Pizza.Text = pizza.ToString("N2");
            textBox2ExtraToppings.Text = toppings.ToString("N2");
            textBox3Drinks.Text = drinks.ToString("N2");
            textBox4Total.Text = (pizza + toppings + drinks).ToString("N2");
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            // back to the default selections
            SizeSmallradioButton1.Checked = true;
            CrustTypeThinradioButton4.Checked = true;
            DrinksSoftdrinkradioButton6.Checked = true;
            DineInradioButton9.Checked = true;

            btnClearToppings_Click(sender, e);

            textBox1Pizza.Text = "";
            textBox2ExtraToppings.Text = "";
            textBox3Drinks.Text = "";
            textBox4Total.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ---------- Empty handlers (kept so the designer stays happy) ----------
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void MachineProblem5_Load(object sender, EventArgs e)
        {
            clock.Interval = 1000;                          // tick every second
            clock.Tick += new EventHandler(UpdateClock);
            clock.Start();
            UpdateClock(sender, e);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SizeSmallradioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SizeMediumradioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SizeLargeradioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CrustTypeThinradioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CrustTypeThickradioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DrinksSoftdrinkradioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DrinkFruitjuiceradioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DrinkCoffeeradioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DineInradioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TakeOutradioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ExtraCheesecheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MushroomcheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OlivescheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OnionscheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PepperscheckBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TomatoescheckBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2ExtraToppings_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3Drinks_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4Total_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}