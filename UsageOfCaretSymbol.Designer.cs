namespace MachineProblemWInForm
{
    partial class UsageOfCaretSymbol
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
            groupBox1 = new GroupBox();
            equalbtn = new Button();
            exponentresulttxt = new TextBox();
            powertxt = new TextBox();
            basetxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            diameter = new Button();
            circumferencebtn = new Button();
            areabtn = new Button();
            diametertxt = new TextBox();
            circumferencetxt = new TextBox();
            areatxt = new TextBox();
            radiustxt = new TextBox();
            label3 = new Label();
            clearbtn = new Button();
            exitbtn = new Button();
            circlePanel = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(equalbtn);
            groupBox1.Controls.Add(exponentresulttxt);
            groupBox1.Controls.Add(powertxt);
            groupBox1.Controls.Add(basetxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(37, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 286);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Exponent";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // equalbtn
            // 
            equalbtn.BackColor = Color.Pink;
            equalbtn.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            equalbtn.Location = new Point(32, 204);
            equalbtn.Name = "equalbtn";
            equalbtn.Size = new Size(63, 40);
            equalbtn.TabIndex = 12;
            equalbtn.Text = "=";
            equalbtn.UseVisualStyleBackColor = false;
            equalbtn.Click += equalbtn_Click;
            // 
            // exponentresulttxt
            // 
            exponentresulttxt.Location = new Point(127, 204);
            exponentresulttxt.Name = "exponentresulttxt";
            exponentresulttxt.Size = new Size(136, 32);
            exponentresulttxt.TabIndex = 4;
            exponentresulttxt.TextChanged += exponentresulttxt_TextChanged;
            // 
            // powertxt
            // 
            powertxt.Location = new Point(127, 127);
            powertxt.Name = "powertxt";
            powertxt.Size = new Size(136, 32);
            powertxt.TabIndex = 3;
            powertxt.TextChanged += powertxt_TextChanged;
            // 
            // basetxt
            // 
            basetxt.Location = new Point(127, 59);
            basetxt.Name = "basetxt";
            basetxt.Size = new Size(136, 32);
            basetxt.TabIndex = 2;
            basetxt.TextChanged += basetxt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 134);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 1;
            label2.Text = "Power";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 62);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 0;
            label1.Text = "Base";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(diameter);
            groupBox2.Controls.Add(circumferencebtn);
            groupBox2.Controls.Add(areabtn);
            groupBox2.Controls.Add(diametertxt);
            groupBox2.Controls.Add(circumferencetxt);
            groupBox2.Controls.Add(areatxt);
            groupBox2.Controls.Add(radiustxt);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(374, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 365);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Circle";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // diameter
            // 
            diameter.BackColor = Color.Pink;
            diameter.Location = new Point(42, 259);
            diameter.Name = "diameter";
            diameter.Size = new Size(143, 40);
            diameter.TabIndex = 11;
            diameter.Text = "Diameter";
            diameter.UseVisualStyleBackColor = false;
            diameter.Click += diameter_Click;
            // 
            // circumferencebtn
            // 
            circumferencebtn.BackColor = Color.Pink;
            circumferencebtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            circumferencebtn.Location = new Point(42, 204);
            circumferencebtn.Name = "circumferencebtn";
            circumferencebtn.Size = new Size(143, 40);
            circumferencebtn.TabIndex = 10;
            circumferencebtn.Text = "Circumference";
            circumferencebtn.UseVisualStyleBackColor = false;
            circumferencebtn.Click += circumferencebtn_Click;
            // 
            // areabtn
            // 
            areabtn.BackColor = Color.Pink;
            areabtn.Location = new Point(42, 144);
            areabtn.Name = "areabtn";
            areabtn.Size = new Size(143, 40);
            areabtn.TabIndex = 9;
            areabtn.Text = "Area";
            areabtn.UseVisualStyleBackColor = false;
            areabtn.Click += areabtn_Click;
            // 
            // diametertxt
            // 
            diametertxt.Location = new Point(220, 259);
            diametertxt.Name = "diametertxt";
            diametertxt.Size = new Size(136, 32);
            diametertxt.TabIndex = 8;
            diametertxt.TextChanged += diametertxt_TextChanged;
            // 
            // circumferencetxt
            // 
            circumferencetxt.Location = new Point(220, 204);
            circumferencetxt.Name = "circumferencetxt";
            circumferencetxt.Size = new Size(136, 32);
            circumferencetxt.TabIndex = 7;
            circumferencetxt.TextChanged += circumferencetxt_TextChanged;
            // 
            // areatxt
            // 
            areatxt.Location = new Point(220, 150);
            areatxt.Name = "areatxt";
            areatxt.Size = new Size(136, 32);
            areatxt.TabIndex = 6;
            areatxt.TextChanged += areatxt_TextChanged;
            // 
            // radiustxt
            // 
            radiustxt.Location = new Point(220, 75);
            radiustxt.Name = "radiustxt";
            radiustxt.Size = new Size(136, 32);
            radiustxt.TabIndex = 5;
            radiustxt.TextChanged += radiustxt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 78);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 2;
            label3.Text = "Radius";
            // 
            // clearbtn
            // 
            clearbtn.BackColor = Color.Pink;
            clearbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            clearbtn.Location = new Point(37, 344);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(145, 55);
            clearbtn.TabIndex = 2;
            clearbtn.Text = "Clear All";
            clearbtn.UseVisualStyleBackColor = false;
            clearbtn.Click += clearbtn_Click;
            // 
            // exitbtn
            // 
            exitbtn.BackColor = Color.PaleVioletRed;
            exitbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            exitbtn.Location = new Point(188, 344);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(140, 55);
            exitbtn.TabIndex = 3;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = false;
            exitbtn.Click += exitbtn_Click;
            // 
            // circlePanel
            // 
            circlePanel.BorderStyle = BorderStyle.FixedSingle;
            circlePanel.Location = new Point(781, 48);
            circlePanel.Name = "circlePanel";
            circlePanel.Size = new Size(295, 351);
            circlePanel.TabIndex = 4;
            circlePanel.Paint += circlePanel_Paint;
            // 
            // UsageOfCaretSymbol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1105, 450);
            Controls.Add(circlePanel);
            Controls.Add(exitbtn);
            Controls.Add(clearbtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "UsageOfCaretSymbol";
            Text = "UsageOfCaretSymbol";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private Button clearbtn;
        private Button exitbtn;
        private Button equalbtn;
        private TextBox exponentresulttxt;
        private TextBox powertxt;
        private TextBox basetxt;
        private Button diameter;
        private Button button4;
        private Button areabtn;
        private TextBox diametertxt;
        private TextBox circumferencetxt;
        private TextBox areatxt;
        private TextBox radiustxt;
        public Button circumferencebtn;
        private Panel circlePanel;
    }
}