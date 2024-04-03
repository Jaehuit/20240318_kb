using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomT01
{
    public partial class Form1 : Form
    {
        int answer = 0;
        public Form1()
        {
            InitializeComponent();
            answer = new Random().Next(9) + 1;
            Console.WriteLine(answer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mynum = int.Parse(textBox1.Text);
            if (mynum == answer)
            {
                MessageBox.Show("정답");
                answer = new Random().Next(9)+ 1;
                Console.WriteLine(answer);
            }
            else
            {
                if(mynum>answer)
                    MessageBox.Show("정답보다 더 큰 값임");
                else
                    MessageBox.Show("정답보다 더 작은 값임");
            }
        
        }

        private void button_gawi_Click(object sender, EventArgs e)
        {
            int computer = new Random().Next(3);
            if(computer == 0)
                MessageBox.Show("비김");
            if (computer == 1)
                MessageBox.Show("내가 짐");
            if (computer == 2)
                MessageBox.Show("내가 이김");
        }

        private void button_bawi_Click(object sender, EventArgs e)
        {
            int computer = new Random().Next(3);
            if (computer == 0)
                MessageBox.Show("이김");
            if (computer == 1)
                MessageBox.Show("비김");
            if (computer == 2)
                MessageBox.Show("짐");
        }

        private void button_bo_Click(object sender, EventArgs e)
        {
            int computer = new Random().Next(3);
            if (computer == 0)
                MessageBox.Show("짐");
            if (computer == 1)
                MessageBox.Show("이김");
            if (computer == 2)
                MessageBox.Show("비김");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> strings = new List<string>();
            strings.Add("안녕");
            strings.Add("반가워");
            strings.Add("Hello");

            label1.Text = strings[new Random().Next(strings.Count)];
        }
    }
}
