using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

   
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void jiahao_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.input1.Text);
            var y = int.Parse(this.input2.Text);
            var z = x + y;
            this.label1.Text = z.ToString();


        }

        private void jianhao_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.input1.Text);
            var y = int.Parse(this.input2.Text);
            var z = x - y;
            this.label1.Text = z.ToString();
        }

        private void chuhao_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.input1.Text);
            var y = int.Parse(this.input2.Text);
            if (y != 0)
            {
                var z = x / y;
                this.label1.Text = z.ToString();
            }
            else {
                this.label1.Text = '除数不能为0';
            }
            
        }

        private void chenghao_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.input1.Text);
            var y = int.Parse(this.input2.Text);
            var z = x * y;
            this.label1.Text = z.ToString();
        }
    }
}
