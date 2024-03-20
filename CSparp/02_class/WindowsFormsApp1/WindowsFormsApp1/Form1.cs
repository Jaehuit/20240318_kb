using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class textBox_1 : Form
    {
        public textBox_1()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox_test.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox_test.Text;
            int[] lotto = new int[6];
            Random r = new Random();
            for (int i=0; i < lotto.Length; i++) ;
            {
                int num = r.Next(45) + 1;
                if(lotto.Contains(num))
                {
                    i--;
                    continue;
                }
                lotto[i] = num;
            }
            int bns = r.Next(45) + 1;
            while (lotto.Contains(bns))
                bns = r.Next(45) + 1;
            Array.Sort(lotto);  
            label2.Text=string.Join(",",lotto);
            label2.Text += "보너스번호:" + bns;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox temp = new TextBox();
            temp.Text = textBox_test.Text;  
            temp.Location=new Point(100,100);    
            Controls.Add(temp);
        }
    }
}
