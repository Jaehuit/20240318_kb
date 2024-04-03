using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp033
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";

            button3.Click += Button_Click;

        }

        private void Button_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text += "+";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label3.Text = "";
            label2.Text += "+";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("yyyy년 MM월dd일HH시mm분ss초");
        }
    }
}
