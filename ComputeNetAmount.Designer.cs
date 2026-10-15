namespace MachineProblemWInForm
{
    partial class ComputeNetAmount
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
            Button calculatebtn;
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            clearbtn = new Button();
            closebtn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            calculatebtn = new Button();
            SuspendLayout();
            // 
            // calculatebtn
            // 
            calculatebtn.BackColor = Color.BurlyWood;
            calculatebtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            calculatebtn.Location = new Point(95, 346);
            calculatebtn.Name = "calculatebtn";
            calculatebtn.Size = new Size(151, 53);
            calculatebtn.TabIndex = 5;
            calculatebtn.Text = "Calculate";
            calculatebtn.UseVisualStyleBackColor = false;
            calculatebtn.Click += calculatebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(70, 57);
            label1.Name = "label1";
            label1.Size = new Size(167, 23);
            label1.TabIndex = 0;
            label1.Text = "Product Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(70, 116);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 1;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(140, 177);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Sub-Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(140, 223);
            label4.Name = "label4";
            label4.Size = new Size(177, 23);
            label4.TabIndex = 3;
            label4.Text = "Discount Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.Location = new Point(70, 275);
            label5.Name = "label5";
            label5.Size = new Size(127, 23);
            label5.TabIndex = 4;
            label5.Text = "Net Amount";
            // 
            // clearbtn
            // 
            clearbtn.BackColor = Color.BurlyWood;
            clearbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            clearbtn.Location = new Point(244, 346);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(151, 53);
            clearbtn.TabIndex = 6;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = false;
            clearbtn.Click += clearbtn_Click;
            // 
            // closebtn
            // 
            closebtn.BackColor = Color.LightCoral;
            closebtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            closebtn.Location = new Point(393, 346);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(151, 53);
            closebtn.TabIndex = 7;
            closebtn.Text = "Close";
            closebtn.UseVisualStyleBackColor = false;
            closebtn.Click += closebtn_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            textBox1.Location = new Point(272, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 32);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            textBox2.Location = new Point(272, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 32);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            textBox3.Location = new Point(323, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 32);
            textBox3.TabIndex = 10;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            textBox4.Location = new Point(323, 220);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(164, 32);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            textBox5.Location = new Point(272, 272);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(164, 32);
            textBox5.TabIndex = 12;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // ComputeNetAmount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(621, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(closebtn);
            Controls.Add(clearbtn);
            Controls.Add(calculatebtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ComputeNetAmount";
            Text = "ComputeNetAmount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button calculatebtn;
        private Button clearbtn;
        private Button closebtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}