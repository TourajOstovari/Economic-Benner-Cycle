namespace Benner_Cycle
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
            txtYear = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Start Year:";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(14, 31);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(159, 23);
            txtYear.TabIndex = 1;
            txtYear.Text = "1924";
            // 
            // button1
            // 
            button1.Location = new Point(179, 31);
            button1.Name = "button1";
            button1.Size = new Size(94, 23);
            button1.TabIndex = 2;
            button1.Text = "Calculate ... ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 82);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 3;
            label2.Text = "Mirror Cycle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 84);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 4;
            label3.Text = "Major Cycle";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(16, 107);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(192, 331);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(325, 107);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(219, 331);
            richTextBox2.TabIndex = 8;
            richTextBox2.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 39);
            label4.Name = "label4";
            label4.Size = new Size(241, 15);
            label4.TabIndex = 9;
            label4.Text = "Mirror Start Year: 1924, Major Start Year: 1927";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtYear);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Economic Benner Cycle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtYear;
        private Button button1;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label4;
    }
}
