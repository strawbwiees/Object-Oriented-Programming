namespace MachineProblemWInForm
{
    partial class GradeComputation
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            computebtn = new Button();
            clearbtn = new Button();
            closebtn = new Button();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            groupBox1.Location = new Point(50, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(691, 282);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Grades Data Entry";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(167, 198);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(182, 36);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 36);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 36);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 205);
            label3.Name = "label3";
            label3.Size = new Size(64, 27);
            label3.TabIndex = 2;
            label3.Text = "Final";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 130);
            label2.Name = "label2";
            label2.Size = new Size(105, 27);
            label2.TabIndex = 1;
            label2.Text = "Midterm";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 59);
            label1.Name = "label1";
            label1.Size = new Size(81, 27);
            label1.TabIndex = 0;
            label1.Text = "Prelim";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label4.Location = new Point(415, 56);
            label4.Name = "label4";
            label4.Size = new Size(198, 27);
            label4.TabIndex = 6;
            label4.Text = "Semestral Grade";
            label4.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            textBox4.Location = new Point(415, 95);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(182, 36);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // computebtn
            // 
            computebtn.BackColor = Color.LightSteelBlue;
            computebtn.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            computebtn.Location = new Point(124, 378);
            computebtn.Name = "computebtn";
            computebtn.Size = new Size(157, 58);
            computebtn.TabIndex = 7;
            computebtn.Text = "Compute";
            computebtn.UseVisualStyleBackColor = false;
            computebtn.Click += computebtn_Click;
            // 
            // clearbtn
            // 
            clearbtn.BackColor = Color.LightSteelBlue;
            clearbtn.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            clearbtn.Location = new Point(315, 378);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(157, 58);
            clearbtn.TabIndex = 8;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = false;
            clearbtn.Click += clearbtn_Click;
            // 
            // closebtn
            // 
            closebtn.BackColor = Color.LightCoral;
            closebtn.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            closebtn.Location = new Point(506, 378);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(157, 58);
            closebtn.TabIndex = 9;
            closebtn.Text = "Close";
            closebtn.UseVisualStyleBackColor = false;
            closebtn.Click += closebtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label5.Location = new Point(415, 150);
            label5.Name = "label5";
            label5.Size = new Size(83, 27);
            label5.TabIndex = 7;
            label5.Text = "Status:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label6.Location = new Point(424, 187);
            label6.Name = "label6";
            label6.Size = new Size(94, 27);
            label6.TabIndex = 8;
            label6.Text = "PASSED";
            label6.Click += label6_Click;
            // 
            // GradeComputation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 486);
            Controls.Add(closebtn);
            Controls.Add(clearbtn);
            Controls.Add(computebtn);
            Controls.Add(groupBox1);
            Name = "GradeComputation";
            Text = "GradeComputation";
            Load += GradeComputation_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox textBox4;
        private Button computebtn;
        private Button clearbtn;
        private Button closebtn;
        private Label label6;
        private Label label5;
    }
}