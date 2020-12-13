namespace DrawMe
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button13 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.red = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.purple = new System.Windows.Forms.Button();
            this.orange = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.darkBlue = new System.Windows.Forms.Button();
            this.yellow = new System.Windows.Forms.Button();
            this.black = new System.Windows.Forms.Button();
            this.white = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(355, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1013, 734);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Кисть";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Линия";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ломанная";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "Прямоугольник";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 341);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 49);
            this.button5.TabIndex = 5;
            this.button5.Text = "Квадрат";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 396);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(192, 49);
            this.button6.TabIndex = 6;
            this.button6.Text = "Окружность";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 451);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(192, 49);
            this.button7.TabIndex = 7;
            this.button7.Text = "Эллипс";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 506);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(192, 49);
            this.button8.TabIndex = 8;
            this.button8.Text = "Треугольник по трем";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 562);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(192, 49);
            this.button9.TabIndex = 9;
            this.button9.Text = "Треугольник 90";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 617);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(192, 49);
            this.button10.TabIndex = 10;
            this.button10.Text = "Равнобедренный";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 672);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(192, 49);
            this.button11.TabIndex = 11;
            this.button11.Text = "N-угольник";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(12, 727);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(192, 49);
            this.button12.TabIndex = 12;
            this.button12.Text = "Правильный N-угольник";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(225, 632);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(225, 121);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(112, 49);
            this.button13.TabIndex = 14;
            this.button13.Text = "Очистить форму";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Панель инструментов:";
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Location = new System.Drawing.Point(285, 176);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(52, 49);
            this.red.TabIndex = 16;
            this.red.UseVisualStyleBackColor = false;
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.green.Location = new System.Drawing.Point(285, 341);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(52, 49);
            this.green.TabIndex = 17;
            this.green.UseVisualStyleBackColor = false;
            // 
            // purple
            // 
            this.purple.BackColor = System.Drawing.Color.Purple;
            this.purple.Location = new System.Drawing.Point(285, 506);
            this.purple.Name = "purple";
            this.purple.Size = new System.Drawing.Size(52, 49);
            this.purple.TabIndex = 18;
            this.purple.UseVisualStyleBackColor = false;
            this.purple.Click += new System.EventHandler(this.purple_Click);
            // 
            // orange
            // 
            this.orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orange.Location = new System.Drawing.Point(285, 231);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(52, 49);
            this.orange.TabIndex = 19;
            this.orange.UseVisualStyleBackColor = false;
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Aqua;
            this.blue.Location = new System.Drawing.Point(285, 396);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(52, 49);
            this.blue.TabIndex = 20;
            this.blue.UseVisualStyleBackColor = false;
            // 
            // darkBlue
            // 
            this.darkBlue.BackColor = System.Drawing.Color.Blue;
            this.darkBlue.Location = new System.Drawing.Point(285, 451);
            this.darkBlue.Name = "darkBlue";
            this.darkBlue.Size = new System.Drawing.Size(52, 49);
            this.darkBlue.TabIndex = 21;
            this.darkBlue.UseVisualStyleBackColor = false;
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.Location = new System.Drawing.Point(285, 286);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(52, 49);
            this.yellow.TabIndex = 22;
            this.yellow.UseVisualStyleBackColor = false;
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.Location = new System.Drawing.Point(227, 562);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(52, 49);
            this.black.TabIndex = 23;
            this.black.UseVisualStyleBackColor = false;
            // 
            // white
            // 
            this.white.BackColor = System.Drawing.Color.White;
            this.white.Location = new System.Drawing.Point(285, 562);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(52, 49);
            this.white.TabIndex = 24;
            this.white.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(225, 190);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 22);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1393, 798);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.white);
            this.Controls.Add(this.black);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.darkBlue);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.orange);
            this.Controls.Add(this.purple);
            this.Controls.Add(this.green);
            this.Controls.Add(this.red);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button green;
        private System.Windows.Forms.Button purple;
        private System.Windows.Forms.Button orange;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button darkBlue;
        private System.Windows.Forms.Button yellow;
        private System.Windows.Forms.Button black;
        private System.Windows.Forms.Button white;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

