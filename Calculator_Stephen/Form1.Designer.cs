namespace Calculator_Stephen
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(150, 41);
            label1.TabIndex = 0;
            label1.Text = "Calculator";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 47);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(472, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 47);
            textBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+, -, *, /" });
            comboBox1.Location = new Point(302, 359);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(302, 49);
            comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(125, 489);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 1029);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button button1;
    }
}
