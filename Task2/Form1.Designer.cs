namespace Task2
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
            a_textBox = new TextBox();
            b_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            f_textBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(356, 332);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // a_textBox
            // 
            a_textBox.Location = new Point(245, 177);
            a_textBox.Name = "a_textBox";
            a_textBox.Size = new Size(125, 27);
            a_textBox.TabIndex = 1;
            // 
            // b_textBox
            // 
            b_textBox.Location = new Point(414, 177);
            b_textBox.Name = "b_textBox";
            b_textBox.Size = new Size(125, 27);
            b_textBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 99);
            label1.Name = "label1";
            label1.Size = new Size(235, 20);
            label1.TabIndex = 4;
            label1.Text = "Введите значения для формулы:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 180);
            label2.Name = "label2";
            label2.Size = new Size(20, 20);
            label2.TabIndex = 5;
            label2.Text = "a:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(387, 180);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 6;
            label3.Text = "b:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(183, 249);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 7;
            label4.Text = "Результат";
            // 
            // f_textBox
            // 
            f_textBox.Location = new Point(264, 246);
            f_textBox.Name = "f_textBox";
            f_textBox.Size = new Size(317, 27);
            f_textBox.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(f_textBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(b_textBox);
            Controls.Add(a_textBox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox a_textBox;
        private TextBox b_textBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox f_textBox;
    }
}
