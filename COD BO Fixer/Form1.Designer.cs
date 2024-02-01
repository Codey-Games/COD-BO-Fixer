namespace COD_BO_Fixer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            label2 = new Label();
            button3 = new Button();
            label3 = new Label();
            checkBox2 = new CheckBox();
            button4 = new Button();
            button5 = new Button();
            label4 = new Label();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label5 = new Label();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            progress = new ProgressBar();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AllowDrop = true;
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Example: C:\\SteamLibrary\\Call of Duty Black Ops\\BlackOps.exe";
            textBox1.Size = new Size(382, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 15);
            label1.TabIndex = 1;
            label1.Text = "Please enter the path to the executable:";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(12, 56);
            button1.Name = "button1";
            button1.Size = new Size(217, 23);
            button1.TabIndex = 2;
            button1.Text = "Apply Patch";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(235, 56);
            button2.Name = "button2";
            button2.Size = new Size(217, 23);
            button2.TabIndex = 3;
            button2.TabStop = false;
            button2.Text = "Remove Patch";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(371, 10);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 4;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(385, 9);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "Correct File";
            label2.TextChanged += label2_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(400, 27);
            button3.Name = "button3";
            button3.Size = new Size(23, 23);
            button3.TabIndex = 6;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 271);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 8;
            label3.Text = "Patch Applied";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Enabled = false;
            checkBox2.Location = new Point(98, 271);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 7;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(9, 116);
            button4.Name = "button4";
            button4.Size = new Size(217, 23);
            button4.TabIndex = 9;
            button4.Text = "Create Shortcuts";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(232, 116);
            button5.Name = "button5";
            button5.Size = new Size(217, 23);
            button5.TabIndex = 10;
            button5.Text = "Remove Shortcuts";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(235, 9);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 11;
            label4.Text = "Made by cod.y";
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.Image = Properties.Resources.folder1;
            button6.Location = new Point(429, 27);
            button6.Name = "button6";
            button6.Size = new Size(23, 23);
            button6.TabIndex = 12;
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Enabled = false;
            button7.Location = new Point(308, 267);
            button7.Name = "button7";
            button7.Size = new Size(141, 23);
            button7.TabIndex = 13;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Enabled = false;
            button8.Location = new Point(9, 145);
            button8.Name = "button8";
            button8.Size = new Size(440, 23);
            button8.TabIndex = 14;
            button8.Text = "Open Server Starter";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLightLight;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(12, 98);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 15;
            label5.Text = "Other Settings";
            // 
            // button9
            // 
            button9.Enabled = false;
            button9.Location = new Point(12, 295);
            button9.Name = "button9";
            button9.Size = new Size(217, 23);
            button9.TabIndex = 17;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Enabled = false;
            button10.Location = new Point(235, 295);
            button10.Name = "button10";
            button10.Size = new Size(217, 23);
            button10.TabIndex = 16;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Enabled = false;
            button11.Location = new Point(12, 324);
            button11.Name = "button11";
            button11.Size = new Size(217, 23);
            button11.TabIndex = 18;
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Enabled = false;
            button12.Location = new Point(235, 324);
            button12.Name = "button12";
            button12.Size = new Size(217, 23);
            button12.TabIndex = 19;
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // progress
            // 
            progress.Location = new Point(9, 174);
            progress.Name = "progress";
            progress.Size = new Size(440, 13);
            progress.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(464, 197);
            Controls.Add(progress);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(label5);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(checkBox2);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Call of Duty: Black Ops - Fixer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
        private Label label2;
        private Button button3;
        private Label label3;
        private CheckBox checkBox2;
        private Button button4;
        private Button button5;
        private Label label4;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label5;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private ProgressBar progress;
    }
}
