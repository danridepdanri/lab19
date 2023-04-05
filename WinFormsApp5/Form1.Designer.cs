namespace WinFormsApp5
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
            button1 = new Button();
            button2 = new Button();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(77, 337);
            button1.Name = "button1";
            button1.Size = new Size(220, 51);
            button1.TabIndex = 0;
            button1.Text = "removeDigits";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(397, 337);
            button2.Name = "button2";
            button2.Size = new Size(220, 51);
            button2.TabIndex = 1;
            button2.Text = "DoubleSpaces";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(40, 57);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(292, 23);
            textBox8.TabIndex = 2;
            textBox8.Text = "Введите строку";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(367, 57);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(380, 23);
            textBox9.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button2;
        private TextBox textBox8;
        private TextBox textBox9;
    }
}