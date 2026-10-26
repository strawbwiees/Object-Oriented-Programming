namespace MachineProblemWInForm
{
    partial class MachineProblem5
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            SizegroupBox1 = new GroupBox();
            SizeLargeradioButton3 = new RadioButton();
            SizeMediumradioButton2 = new RadioButton();
            SizeSmallradioButton1 = new RadioButton();
            CrustTypegroupBox2 = new GroupBox();
            CrustTypeThickradioButton5 = new RadioButton();
            CrustTypeThinradioButton4 = new RadioButton();
            DrinksgroupBox3 = new GroupBox();
            DrinkCoffeeradioButton8 = new RadioButton();
            DrinkFruitjuiceradioButton7 = new RadioButton();
            DrinksSoftdrinkradioButton6 = new RadioButton();
            ExtraToppingsgroupBox4 = new GroupBox();
            TomatoescheckBox6 = new CheckBox();
            PepperscheckBox5 = new CheckBox();
            OnionscheckBox4 = new CheckBox();
            OlivescheckBox3 = new CheckBox();
            MushroomcheckBox2 = new CheckBox();
            ExtraCheesecheckBox1 = new CheckBox();
            btnBuildPizza = new Button();
            btnClearToppings = new Button();
            groupBox5 = new GroupBox();
            textBox4Total = new TextBox();
            textBox3Drinks = new TextBox();
            textBox2ExtraToppings = new TextBox();
            textBox1Pizza = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCompute = new Button();
            DineInradioButton9 = new RadioButton();
            TakeOutradioButton10 = new RadioButton();
            btnClearAll = new Button();
            btnExit = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SizegroupBox1.SuspendLayout();
            CrustTypegroupBox2.SuspendLayout();
            DrinksgroupBox3.SuspendLayout();
            ExtraToppingsgroupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepPink;
            label1.Location = new Point(44, 41);
            label1.Name = "label1";
            label1.Size = new Size(118, 40);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // SizegroupBox1
            // 
            SizegroupBox1.Controls.Add(SizeLargeradioButton3);
            SizegroupBox1.Controls.Add(SizeMediumradioButton2);
            SizegroupBox1.Controls.Add(SizeSmallradioButton1);
            SizegroupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            SizegroupBox1.Location = new Point(44, 121);
            SizegroupBox1.Name = "SizegroupBox1";
            SizegroupBox1.Size = new Size(261, 222);
            SizegroupBox1.TabIndex = 1;
            SizegroupBox1.TabStop = false;
            SizegroupBox1.Text = "Size";
            // 
            // SizeLargeradioButton3
            // 
            SizeLargeradioButton3.AutoSize = true;
            SizeLargeradioButton3.Location = new Point(31, 144);
            SizeLargeradioButton3.Name = "SizeLargeradioButton3";
            SizeLargeradioButton3.Size = new Size(85, 27);
            SizeLargeradioButton3.TabIndex = 2;
            SizeLargeradioButton3.TabStop = true;
            SizeLargeradioButton3.Text = "Large";
            SizeLargeradioButton3.UseVisualStyleBackColor = true;
            SizeLargeradioButton3.CheckedChanged += SizeLargeradioButton3_CheckedChanged;
            // 
            // SizeMediumradioButton2
            // 
            SizeMediumradioButton2.AutoSize = true;
            SizeMediumradioButton2.Location = new Point(31, 93);
            SizeMediumradioButton2.Name = "SizeMediumradioButton2";
            SizeMediumradioButton2.Size = new Size(111, 27);
            SizeMediumradioButton2.TabIndex = 1;
            SizeMediumradioButton2.TabStop = true;
            SizeMediumradioButton2.Text = "Medium";
            SizeMediumradioButton2.UseVisualStyleBackColor = true;
            SizeMediumradioButton2.CheckedChanged += SizeMediumradioButton2_CheckedChanged;
            // 
            // SizeSmallradioButton1
            // 
            SizeSmallradioButton1.AutoSize = true;
            SizeSmallradioButton1.Location = new Point(31, 45);
            SizeSmallradioButton1.Name = "SizeSmallradioButton1";
            SizeSmallradioButton1.Size = new Size(83, 27);
            SizeSmallradioButton1.TabIndex = 0;
            SizeSmallradioButton1.TabStop = true;
            SizeSmallradioButton1.Text = "Small";
            SizeSmallradioButton1.UseVisualStyleBackColor = true;
            SizeSmallradioButton1.CheckedChanged += SizeSmallradioButton1_CheckedChanged;
            // 
            // CrustTypegroupBox2
            // 
            CrustTypegroupBox2.Controls.Add(CrustTypeThickradioButton5);
            CrustTypegroupBox2.Controls.Add(CrustTypeThinradioButton4);
            CrustTypegroupBox2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            CrustTypegroupBox2.Location = new Point(42, 374);
            CrustTypegroupBox2.Name = "CrustTypegroupBox2";
            CrustTypegroupBox2.Size = new Size(261, 168);
            CrustTypegroupBox2.TabIndex = 2;
            CrustTypegroupBox2.TabStop = false;
            CrustTypegroupBox2.Text = "Crust type";
            // 
            // CrustTypeThickradioButton5
            // 
            CrustTypeThickradioButton5.AutoSize = true;
            CrustTypeThickradioButton5.Location = new Point(33, 95);
            CrustTypeThickradioButton5.Name = "CrustTypeThickradioButton5";
            CrustTypeThickradioButton5.Size = new Size(136, 27);
            CrustTypeThickradioButton5.TabIndex = 4;
            CrustTypeThickradioButton5.TabStop = true;
            CrustTypeThickradioButton5.Text = "Thick Crust";
            CrustTypeThickradioButton5.UseVisualStyleBackColor = true;
            CrustTypeThickradioButton5.CheckedChanged += CrustTypeThickradioButton5_CheckedChanged;
            // 
            // CrustTypeThinradioButton4
            // 
            CrustTypeThinradioButton4.AutoSize = true;
            CrustTypeThinradioButton4.Location = new Point(33, 44);
            CrustTypeThinradioButton4.Name = "CrustTypeThinradioButton4";
            CrustTypeThinradioButton4.Size = new Size(123, 27);
            CrustTypeThinradioButton4.TabIndex = 3;
            CrustTypeThinradioButton4.TabStop = true;
            CrustTypeThinradioButton4.Text = "Thin Crust";
            CrustTypeThinradioButton4.UseVisualStyleBackColor = true;
            CrustTypeThinradioButton4.CheckedChanged += CrustTypeThinradioButton4_CheckedChanged;
            // 
            // DrinksgroupBox3
            // 
            DrinksgroupBox3.Controls.Add(DrinkCoffeeradioButton8);
            DrinksgroupBox3.Controls.Add(DrinkFruitjuiceradioButton7);
            DrinksgroupBox3.Controls.Add(DrinksSoftdrinkradioButton6);
            DrinksgroupBox3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            DrinksgroupBox3.Location = new Point(44, 564);
            DrinksgroupBox3.Name = "DrinksgroupBox3";
            DrinksgroupBox3.Size = new Size(261, 228);
            DrinksgroupBox3.TabIndex = 3;
            DrinksgroupBox3.TabStop = false;
            DrinksgroupBox3.Text = "Drinks";
            // 
            // DrinkCoffeeradioButton8
            // 
            DrinkCoffeeradioButton8.AutoSize = true;
            DrinkCoffeeradioButton8.Location = new Point(31, 163);
            DrinkCoffeeradioButton8.Name = "DrinkCoffeeradioButton8";
            DrinkCoffeeradioButton8.Size = new Size(211, 27);
            DrinkCoffeeradioButton8.TabIndex = 7;
            DrinkCoffeeradioButton8.TabStop = true;
            DrinkCoffeeradioButton8.Text = "Coffee/Chocolate";
            DrinkCoffeeradioButton8.UseVisualStyleBackColor = true;
            DrinkCoffeeradioButton8.CheckedChanged += DrinkCoffeeradioButton8_CheckedChanged;
            // 
            // DrinkFruitjuiceradioButton7
            // 
            DrinkFruitjuiceradioButton7.AutoSize = true;
            DrinkFruitjuiceradioButton7.Location = new Point(31, 108);
            DrinkFruitjuiceradioButton7.Name = "DrinkFruitjuiceradioButton7";
            DrinkFruitjuiceradioButton7.Size = new Size(129, 27);
            DrinkFruitjuiceradioButton7.TabIndex = 6;
            DrinkFruitjuiceradioButton7.TabStop = true;
            DrinkFruitjuiceradioButton7.Text = "Fruit Juice";
            DrinkFruitjuiceradioButton7.UseVisualStyleBackColor = true;
            DrinkFruitjuiceradioButton7.CheckedChanged += DrinkFruitjuiceradioButton7_CheckedChanged;
            // 
            // DrinksSoftdrinkradioButton6
            // 
            DrinksSoftdrinkradioButton6.AutoSize = true;
            DrinksSoftdrinkradioButton6.Location = new Point(31, 53);
            DrinksSoftdrinkradioButton6.Name = "DrinksSoftdrinkradioButton6";
            DrinksSoftdrinkradioButton6.Size = new Size(130, 27);
            DrinksSoftdrinkradioButton6.TabIndex = 5;
            DrinksSoftdrinkradioButton6.TabStop = true;
            DrinksSoftdrinkradioButton6.Text = "Soft Drinks";
            DrinksSoftdrinkradioButton6.UseVisualStyleBackColor = true;
            DrinksSoftdrinkradioButton6.CheckedChanged += DrinksSoftdrinkradioButton6_CheckedChanged;
            // 
            // ExtraToppingsgroupBox4
            // 
            ExtraToppingsgroupBox4.Controls.Add(TomatoescheckBox6);
            ExtraToppingsgroupBox4.Controls.Add(PepperscheckBox5);
            ExtraToppingsgroupBox4.Controls.Add(OnionscheckBox4);
            ExtraToppingsgroupBox4.Controls.Add(OlivescheckBox3);
            ExtraToppingsgroupBox4.Controls.Add(MushroomcheckBox2);
            ExtraToppingsgroupBox4.Controls.Add(ExtraCheesecheckBox1);
            ExtraToppingsgroupBox4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            ExtraToppingsgroupBox4.Location = new Point(351, 121);
            ExtraToppingsgroupBox4.Name = "ExtraToppingsgroupBox4";
            ExtraToppingsgroupBox4.Size = new Size(533, 222);
            ExtraToppingsgroupBox4.TabIndex = 4;
            ExtraToppingsgroupBox4.TabStop = false;
            ExtraToppingsgroupBox4.Text = "Extra toppings";
            ExtraToppingsgroupBox4.Enter += groupBox4_Enter;
            // 
            // TomatoescheckBox6
            // 
            TomatoescheckBox6.AutoSize = true;
            TomatoescheckBox6.Location = new Point(280, 144);
            TomatoescheckBox6.Name = "TomatoescheckBox6";
            TomatoescheckBox6.Size = new Size(126, 27);
            TomatoescheckBox6.TabIndex = 5;
            TomatoescheckBox6.Text = "Tomatoes";
            TomatoescheckBox6.UseVisualStyleBackColor = true;
            TomatoescheckBox6.CheckedChanged += TomatoescheckBox6_CheckedChanged;
            // 
            // PepperscheckBox5
            // 
            PepperscheckBox5.AutoSize = true;
            PepperscheckBox5.Location = new Point(280, 94);
            PepperscheckBox5.Name = "PepperscheckBox5";
            PepperscheckBox5.Size = new Size(177, 27);
            PepperscheckBox5.TabIndex = 4;
            PepperscheckBox5.Text = "Green Peppers";
            PepperscheckBox5.UseVisualStyleBackColor = true;
            PepperscheckBox5.CheckedChanged += PepperscheckBox5_CheckedChanged;
            // 
            // OnionscheckBox4
            // 
            OnionscheckBox4.AutoSize = true;
            OnionscheckBox4.Location = new Point(280, 45);
            OnionscheckBox4.Name = "OnionscheckBox4";
            OnionscheckBox4.Size = new Size(100, 27);
            OnionscheckBox4.TabIndex = 3;
            OnionscheckBox4.Text = "Onions";
            OnionscheckBox4.UseVisualStyleBackColor = true;
            OnionscheckBox4.CheckedChanged += OnionscheckBox4_CheckedChanged;
            // 
            // OlivescheckBox3
            // 
            OlivescheckBox3.AutoSize = true;
            OlivescheckBox3.Location = new Point(43, 144);
            OlivescheckBox3.Name = "OlivescheckBox3";
            OlivescheckBox3.Size = new Size(153, 27);
            OlivescheckBox3.TabIndex = 2;
            OlivescheckBox3.Text = "Black Olives";
            OlivescheckBox3.UseVisualStyleBackColor = true;
            OlivescheckBox3.CheckedChanged += OlivescheckBox3_CheckedChanged;
            // 
            // MushroomcheckBox2
            // 
            MushroomcheckBox2.AutoSize = true;
            MushroomcheckBox2.Location = new Point(43, 93);
            MushroomcheckBox2.Name = "MushroomcheckBox2";
            MushroomcheckBox2.Size = new Size(143, 27);
            MushroomcheckBox2.TabIndex = 1;
            MushroomcheckBox2.Text = "Mushrooms";
            MushroomcheckBox2.UseVisualStyleBackColor = true;
            MushroomcheckBox2.CheckedChanged += MushroomcheckBox2_CheckedChanged;
            // 
            // ExtraCheesecheckBox1
            // 
            ExtraCheesecheckBox1.AutoSize = true;
            ExtraCheesecheckBox1.Location = new Point(43, 46);
            ExtraCheesecheckBox1.Name = "ExtraCheesecheckBox1";
            ExtraCheesecheckBox1.Size = new Size(160, 27);
            ExtraCheesecheckBox1.TabIndex = 0;
            ExtraCheesecheckBox1.Text = "Extra Cheese";
            ExtraCheesecheckBox1.UseVisualStyleBackColor = true;
            ExtraCheesecheckBox1.CheckedChanged += ExtraCheesecheckBox1_CheckedChanged;
            // 
            // btnBuildPizza
            // 
            btnBuildPizza.BackColor = Color.Pink;
            btnBuildPizza.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnBuildPizza.Location = new Point(351, 384);
            btnBuildPizza.Name = "btnBuildPizza";
            btnBuildPizza.Size = new Size(274, 39);
            btnBuildPizza.TabIndex = 5;
            btnBuildPizza.Text = "Build Pizza";
            btnBuildPizza.UseVisualStyleBackColor = false;
            btnBuildPizza.Click += btnBuildPizza_Click;
            // 
            // btnClearToppings
            // 
            btnClearToppings.BackColor = Color.Pink;
            btnClearToppings.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnClearToppings.Location = new Point(631, 384);
            btnClearToppings.Name = "btnClearToppings";
            btnClearToppings.Size = new Size(253, 39);
            btnClearToppings.TabIndex = 6;
            btnClearToppings.Text = "Clear Toppings";
            btnClearToppings.UseVisualStyleBackColor = false;
            btnClearToppings.Click += btnClearToppings_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox4Total);
            groupBox5.Controls.Add(textBox3Drinks);
            groupBox5.Controls.Add(textBox2ExtraToppings);
            groupBox5.Controls.Add(textBox1Pizza);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(label2);
            groupBox5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            groupBox5.Location = new Point(351, 461);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(399, 385);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Amount";
            // 
            // textBox4Total
            // 
            textBox4Total.Location = new Point(193, 305);
            textBox4Total.Name = "textBox4Total";
            textBox4Total.Size = new Size(156, 32);
            textBox4Total.TabIndex = 18;
            textBox4Total.TextChanged += textBox4Total_TextChanged;
            // 
            // textBox3Drinks
            // 
            textBox3Drinks.Location = new Point(193, 189);
            textBox3Drinks.Name = "textBox3Drinks";
            textBox3Drinks.Size = new Size(156, 32);
            textBox3Drinks.TabIndex = 17;
            textBox3Drinks.TextChanged += textBox3Drinks_TextChanged;
            // 
            // textBox2ExtraToppings
            // 
            textBox2ExtraToppings.Location = new Point(193, 123);
            textBox2ExtraToppings.Name = "textBox2ExtraToppings";
            textBox2ExtraToppings.Size = new Size(156, 32);
            textBox2ExtraToppings.TabIndex = 16;
            textBox2ExtraToppings.TextChanged += textBox2ExtraToppings_TextChanged;
            // 
            // textBox1Pizza
            // 
            textBox1Pizza.Location = new Point(193, 58);
            textBox1Pizza.Name = "textBox1Pizza";
            textBox1Pizza.Size = new Size(156, 32);
            textBox1Pizza.TabIndex = 15;
            textBox1Pizza.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 308);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 14;
            label5.Text = "TOTAL: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 192);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 13;
            label4.Text = "Drinks:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 123);
            label3.Name = "label3";
            label3.Size = new Size(154, 23);
            label3.TabIndex = 12;
            label3.Text = "Extra Toppings:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 61);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 11;
            label2.Text = "Pizza:";
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.Pink;
            btnCompute.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnCompute.Location = new Point(768, 469);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(116, 119);
            btnCompute.TabIndex = 7;
            btnCompute.Text = "COMPUTE";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // DineInradioButton9
            // 
            DineInradioButton9.AutoSize = true;
            DineInradioButton9.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            DineInradioButton9.Location = new Point(44, 806);
            DineInradioButton9.Name = "DineInradioButton9";
            DineInradioButton9.Size = new Size(98, 27);
            DineInradioButton9.TabIndex = 8;
            DineInradioButton9.TabStop = true;
            DineInradioButton9.Text = "Dine in";
            DineInradioButton9.UseVisualStyleBackColor = true;
            DineInradioButton9.CheckedChanged += DineInradioButton9_CheckedChanged;
            // 
            // TakeOutradioButton10
            // 
            TakeOutradioButton10.AutoSize = true;
            TakeOutradioButton10.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            TakeOutradioButton10.Location = new Point(180, 806);
            TakeOutradioButton10.Name = "TakeOutradioButton10";
            TakeOutradioButton10.Size = new Size(114, 27);
            TakeOutradioButton10.TabIndex = 10;
            TakeOutradioButton10.TabStop = true;
            TakeOutradioButton10.Text = "Take out";
            TakeOutradioButton10.UseVisualStyleBackColor = true;
            TakeOutradioButton10.CheckedChanged += TakeOutradioButton10_CheckedChanged;
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = Color.Pink;
            btnClearAll.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnClearAll.Location = new Point(768, 596);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(116, 125);
            btnClearAll.TabIndex = 11;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightPink;
            btnExit.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnExit.Location = new Point(768, 727);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(116, 119);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // MachineProblem5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(928, 880);
            Controls.Add(btnExit);
            Controls.Add(btnClearAll);
            Controls.Add(TakeOutradioButton10);
            Controls.Add(DineInradioButton9);
            Controls.Add(btnCompute);
            Controls.Add(groupBox5);
            Controls.Add(btnClearToppings);
            Controls.Add(btnBuildPizza);
            Controls.Add(ExtraToppingsgroupBox4);
            Controls.Add(DrinksgroupBox3);
            Controls.Add(CrustTypegroupBox2);
            Controls.Add(SizegroupBox1);
            Controls.Add(label1);
            Name = "MachineProblem5";
            Text = "MachineProblem5";
            Load += MachineProblem5_Load;
            SizegroupBox1.ResumeLayout(false);
            SizegroupBox1.PerformLayout();
            CrustTypegroupBox2.ResumeLayout(false);
            CrustTypegroupBox2.PerformLayout();
            DrinksgroupBox3.ResumeLayout(false);
            DrinksgroupBox3.PerformLayout();
            ExtraToppingsgroupBox4.ResumeLayout(false);
            ExtraToppingsgroupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox SizegroupBox1;
        private GroupBox CrustTypegroupBox2;
        private GroupBox DrinksgroupBox3;
        private GroupBox ExtraToppingsgroupBox4;
        private Button btnBuildPizza;
        private Button btnClearToppings;
        private GroupBox groupBox5;
        private Button btnCompute;
        private RadioButton SizeLargeradioButton3;
        private RadioButton SizeMediumradioButton2;
        private RadioButton SizeSmallradioButton1;
        private RadioButton CrustTypeThickradioButton5;
        private RadioButton CrustTypeThinradioButton4;
        private RadioButton DrinkCoffeeradioButton8;
        private RadioButton DrinkFruitjuiceradioButton7;
        private RadioButton DrinksSoftdrinkradioButton6;
        private CheckBox TomatoescheckBox6;
        private CheckBox PepperscheckBox5;
        private CheckBox OnionscheckBox4;
        private CheckBox OlivescheckBox3;
        private CheckBox MushroomcheckBox2;
        private CheckBox ExtraCheesecheckBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RadioButton DineInradioButton9;
        private RadioButton TakeOutradioButton10;
        private Button btnClearAll;
        private Button btnExit;
        private TextBox textBox4Total;
        private TextBox textBox3Drinks;
        private TextBox textBox2ExtraToppings;
        private TextBox textBox1Pizza;
        private System.Windows.Forms.Timer timer1;
    }
}