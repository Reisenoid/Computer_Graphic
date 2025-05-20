namespace LAB4_IND
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
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            textBox2 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 453);
            panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button8);
            splitContainer1.Panel2.Controls.Add(button7);
            splitContainer1.Panel2.Controls.Add(button6);
            splitContainer1.Panel2.Controls.Add(button5);
            splitContainer1.Panel2.Controls.Add(button4);
            splitContainer1.Panel2.Controls.Add(textBox2);
            splitContainer1.Panel2.Controls.Add(button3);
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(radioButton3);
            splitContainer1.Panel2.Controls.Add(radioButton2);
            splitContainer1.Panel2.Controls.Add(radioButton1);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Size = new Size(793, 453);
            splitContainer1.SplitterDistance = 540;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(540, 453);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(1, 322);
            button4.Name = "button4";
            button4.Size = new Size(244, 34);
            button4.TabIndex = 8;
            button4.Text = "МАСШТАБИРОВАНИЕ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(2, 293);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 23);
            textBox2.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(3, 415);
            button3.Name = "button3";
            button3.Size = new Size(244, 32);
            button3.TabIndex = 6;
            button3.Text = "СБРОС";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(2, 93);
            button2.Name = "button2";
            button2.Size = new Size(245, 23);
            button2.TabIndex = 5;
            button2.Text = "ПОВОРОТ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 23);
            textBox1.TabIndex = 4;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(216, 39);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(32, 19);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Z";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(100, 39);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(32, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Y";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 39);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(32, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "X";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(2, 3);
            button1.Name = "button1";
            button1.Size = new Size(246, 30);
            button1.TabIndex = 0;
            button1.Text = "ПОВЕРХНОСТЬ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(3, 138);
            button5.Name = "button5";
            button5.Size = new Size(243, 31);
            button5.TabIndex = 9;
            button5.Text = "ВВЕРХ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(3, 175);
            button6.Name = "button6";
            button6.Size = new Size(243, 34);
            button6.TabIndex = 10;
            button6.Text = "ВНИЗ";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(3, 215);
            button7.Name = "button7";
            button7.Size = new Size(245, 31);
            button7.TabIndex = 11;
            button7.Text = "ВПРАВО";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(2, 252);
            button8.Name = "button8";
            button8.Size = new Size(243, 35);
            button8.TabIndex = 12;
            button8.Text = "ВЛЕВО";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 453);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Button button1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private TextBox textBox2;
        private Button button5;
        private Button button8;
        private Button button7;
        private Button button6;
    }
}
