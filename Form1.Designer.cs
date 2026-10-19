namespace MachineProblemWInForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            clearbtn = new Button();
            closebtn = new Button();
            additionbtn = new Button();
            groupBox1 = new GroupBox();
            backslashbtn = new Button();
            modulobtn = new Button();
            divisionbtn = new Button();
            multiplicationbtn = new Button();
            subtractionbtn = new Button();
            argument1txt = new TextBox();
            argument2txt = new TextBox();
            resulttxt = new TextBox();
            historyListBox = new ListBox();
            clearHistorybtn = new Button();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(61, 93);
            label1.Name = "label1";
            label1.Size = new Size(140, 23);
            label1.TabIndex = 0;
            label1.Text = "Assignment 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(61, 138);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 1;
            label2.Text = "Assignment 2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.Location = new Point(61, 189);
            label3.Name = "label3";
            label3.Size = new Size(67, 23);
            label3.TabIndex = 2;
            label3.Text = "Result";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.Location = new Point(87, 257);
            label5.Name = "label5";
            label5.Size = new Size(16, 23);
            label5.TabIndex = 4;
            label5.Text = " ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            textBox1.Location = new Point(231, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 32);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            textBox2.Location = new Point(231, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 32);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            textBox3.Location = new Point(231, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(162, 32);
            textBox3.TabIndex = 7;
            // 
            // clearbtn
            // 
            clearbtn.BackColor = Color.Khaki;
            clearbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            clearbtn.Location = new Point(52, 494);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(144, 60);
            clearbtn.TabIndex = 10;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = false;
            clearbtn.Click += clearbtn_Click;
            // 
            // closebtn
            // 
            closebtn.BackColor = Color.LightCoral;
            closebtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            closebtn.Location = new Point(211, 494);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(144, 60);
            closebtn.TabIndex = 11;
            closebtn.Text = "Close";
            closebtn.UseVisualStyleBackColor = false;
            closebtn.Click += closebtn_Click;
            // 
            // additionbtn
            // 
            additionbtn.BackColor = Color.Khaki;
            additionbtn.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            additionbtn.Location = new Point(26, 38);
            additionbtn.Name = "additionbtn";
            additionbtn.Size = new Size(101, 74);
            additionbtn.TabIndex = 12;
            additionbtn.Text = "+";
            additionbtn.UseVisualStyleBackColor = false;
            additionbtn.Click += additionbtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(backslashbtn);
            groupBox1.Controls.Add(modulobtn);
            groupBox1.Controls.Add(divisionbtn);
            groupBox1.Controls.Add(multiplicationbtn);
            groupBox1.Controls.Add(subtractionbtn);
            groupBox1.Controls.Add(additionbtn);
            groupBox1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(52, 257);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 220);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operations";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // backslashbtn
            // 
            backslashbtn.BackColor = Color.Khaki;
            backslashbtn.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backslashbtn.Location = new Point(240, 118);
            backslashbtn.Name = "backslashbtn";
            backslashbtn.Size = new Size(101, 74);
            backslashbtn.TabIndex = 17;
            backslashbtn.Text = "\\";
            backslashbtn.UseVisualStyleBackColor = false;
            backslashbtn.Click += backslashbtn_Click;
            // 
            // modulobtn
            // 
            modulobtn.BackColor = Color.Khaki;
            modulobtn.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modulobtn.Location = new Point(133, 118);
            modulobtn.Name = "modulobtn";
            modulobtn.Size = new Size(101, 74);
            modulobtn.TabIndex = 16;
            modulobtn.Text = "MOD";
            modulobtn.UseVisualStyleBackColor = false;
            modulobtn.Click += modulobtn_Click;
            // 
            // divisionbtn
            // 
            divisionbtn.BackColor = Color.Khaki;
            divisionbtn.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            divisionbtn.Location = new Point(26, 118);
            divisionbtn.Name = "divisionbtn";
            divisionbtn.Size = new Size(101, 74);
            divisionbtn.TabIndex = 15;
            divisionbtn.Text = "/";
            divisionbtn.UseVisualStyleBackColor = false;
            divisionbtn.Click += divisionbtn_Click;
            // 
            // multiplicationbtn
            // 
            multiplicationbtn.BackColor = Color.Khaki;
            multiplicationbtn.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            multiplicationbtn.Location = new Point(240, 38);
            multiplicationbtn.Name = "multiplicationbtn";
            multiplicationbtn.Size = new Size(101, 74);
            multiplicationbtn.TabIndex = 14;
            multiplicationbtn.Text = "*";
            multiplicationbtn.UseVisualStyleBackColor = false;
            multiplicationbtn.Click += multiplicationbtn_Click;
            // 
            // subtractionbtn
            // 
            subtractionbtn.BackColor = Color.Khaki;
            subtractionbtn.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subtractionbtn.Location = new Point(133, 38);
            subtractionbtn.Name = "subtractionbtn";
            subtractionbtn.Size = new Size(101, 74);
            subtractionbtn.TabIndex = 13;
            subtractionbtn.Text = "-";
            subtractionbtn.UseVisualStyleBackColor = false;
            subtractionbtn.Click += subtractionbtn_Click;
            // 
            // argument1txt
            // 
            argument1txt.Location = new Point(231, 93);
            argument1txt.Name = "argument1txt";
            argument1txt.Size = new Size(162, 27);
            argument1txt.TabIndex = 14;
            // 
            // argument2txt
            // 
            argument2txt.Location = new Point(231, 138);
            argument2txt.Name = "argument2txt";
            argument2txt.Size = new Size(162, 27);
            argument2txt.TabIndex = 15;
            // 
            // resulttxt
            // 
            resulttxt.Location = new Point(231, 189);
            resulttxt.Name = "resulttxt";
            resulttxt.Size = new Size(162, 27);
            resulttxt.TabIndex = 16;
            // 
            // historyListBox
            // 
            historyListBox.BackColor = Color.Cornsilk;
            historyListBox.BorderStyle = BorderStyle.FixedSingle;
            historyListBox.FormattingEnabled = true;
            historyListBox.HorizontalScrollbar = true;
            historyListBox.IntegralHeight = false;
            historyListBox.Location = new Point(464, 138);
            historyListBox.Name = "historyListBox";
            historyListBox.Size = new Size(301, 339);
            historyListBox.TabIndex = 17;
            historyListBox.SelectedIndexChanged += historyListBox_SelectedIndexChanged;
            // 
            // clearHistorybtn
            // 
            clearHistorybtn.BackColor = Color.Khaki;
            clearHistorybtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearHistorybtn.Location = new Point(572, 494);
            clearHistorybtn.Name = "clearHistorybtn";
            clearHistorybtn.Size = new Size(193, 57);
            clearHistorybtn.TabIndex = 18;
            clearHistorybtn.Text = "CLEAR HISTORY";
            clearHistorybtn.UseVisualStyleBackColor = false;
            clearHistorybtn.Click += clearHistorybtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(464, 91);
            label4.Name = "label4";
            label4.Size = new Size(234, 23);
            label4.TabIndex = 19;
            label4.Text = "CALCULATION HISTORY";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(800, 606);
            Controls.Add(label4);
            Controls.Add(clearHistorybtn);
            Controls.Add(historyListBox);
            Controls.Add(resulttxt);
            Controls.Add(argument2txt);
            Controls.Add(argument1txt);
            Controls.Add(groupBox1);
            Controls.Add(closebtn);
            Controls.Add(clearbtn);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button clearbtn;
        private Button closebtn;
        private Button additionbtn;
        private GroupBox groupBox1;
        private Button backslashbtn;
        private Button modulobtn;
        private Button divisionbtn;
        private Button multiplicationbtn;
        private Button subtractionbtn;
        private TextBox argument1txt;
        private TextBox argument2txt;
        private TextBox resulttxt;
        private ListBox historyListBox;
        private Button clearHistorybtn;
        private Label label4;
    }
}
