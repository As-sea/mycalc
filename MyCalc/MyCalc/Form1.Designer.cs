namespace MyCalc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dengyu = new System.Windows.Forms.Button();
            this.chuhao = new System.Windows.Forms.Button();
            this.chenghao = new System.Windows.Forms.Button();
            this.jianhao = new System.Windows.Forms.Button();
            this.jiahao = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(34, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 505);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(15, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(700, 122);
            this.panel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "结果";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dengyu);
            this.panel4.Controls.Add(this.chuhao);
            this.panel4.Controls.Add(this.chenghao);
            this.panel4.Controls.Add(this.jianhao);
            this.panel4.Controls.Add(this.jiahao);
            this.panel4.Location = new System.Drawing.Point(479, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 225);
            this.panel4.TabIndex = 1;
            // 
            // dengyu
            // 
            this.dengyu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dengyu.Location = new System.Drawing.Point(24, 171);
            this.dengyu.Name = "dengyu";
            this.dengyu.Size = new System.Drawing.Size(33, 31);
            this.dengyu.TabIndex = 4;
            this.dengyu.Text = "=";
            this.dengyu.UseVisualStyleBackColor = true;
            this.dengyu.Click += new System.EventHandler(this.button5_Click);
            // 
            // chuhao
            // 
            this.chuhao.Location = new System.Drawing.Point(24, 129);
            this.chuhao.Name = "chuhao";
            this.chuhao.Size = new System.Drawing.Size(33, 36);
            this.chuhao.TabIndex = 3;
            this.chuhao.Text = "÷";
            this.chuhao.UseVisualStyleBackColor = true;
            this.chuhao.Click += new System.EventHandler(this.chuhao_Click);
            // 
            // chenghao
            // 
            this.chenghao.Location = new System.Drawing.Point(24, 88);
            this.chenghao.Name = "chenghao";
            this.chenghao.Size = new System.Drawing.Size(33, 35);
            this.chenghao.TabIndex = 2;
            this.chenghao.Text = "×";
            this.chenghao.UseVisualStyleBackColor = true;
            this.chenghao.Click += new System.EventHandler(this.chenghao_Click);
            // 
            // jianhao
            // 
            this.jianhao.Location = new System.Drawing.Point(24, 53);
            this.jianhao.Name = "jianhao";
            this.jianhao.Size = new System.Drawing.Size(33, 29);
            this.jianhao.TabIndex = 1;
            this.jianhao.Text = "-";
            this.jianhao.UseVisualStyleBackColor = true;
            this.jianhao.Click += new System.EventHandler(this.jianhao_Click);
            // 
            // jiahao
            // 
            this.jiahao.Location = new System.Drawing.Point(24, 17);
            this.jiahao.Name = "jiahao";
            this.jiahao.Size = new System.Drawing.Size(33, 30);
            this.jiahao.TabIndex = 0;
            this.jiahao.Text = "+";
            this.jiahao.UseVisualStyleBackColor = true;
            this.jiahao.Click += new System.EventHandler(this.jiahao_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.input2);
            this.panel2.Controls.Add(this.input1);
            this.panel2.Location = new System.Drawing.Point(15, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 133);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(15, 85);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(387, 27);
            this.input2.TabIndex = 1;
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(14, 30);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(388, 27);
            this.input1.TabIndex = 0;
            this.input1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 537);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button dengyu;
        private System.Windows.Forms.Button chuhao;
        private System.Windows.Forms.Button chenghao;
        private System.Windows.Forms.Button jianhao;
        private System.Windows.Forms.Button jiahao;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox input1;
    }
}

