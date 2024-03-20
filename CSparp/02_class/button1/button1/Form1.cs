using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button1
{
    public partial class Form1 : Form
    {
        public List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();

            Random rand = new Random();

            button1.Text = rand.Next(100).ToString();
            button5.Text = button1.Text;
            button2.Text = rand.Next(100).ToString();
            button6.Text = button1.Text;
            button3.Text = rand.Next(100).ToString();
            button7.Text = button1.Text;
            button4.Text = rand.Next(100).ToString();
            button8.Text = button1.Text;
        }

        // 버튼1 클릭 이벤트 핸들러
        private void button1_Click(object sender, EventArgs e)
        {
            // 버튼1의 텍스트를 리스트에 추가
            list.Add(button1.Text);

            // 리스트 텍스트 지우고 업데이트
            ListText.Text = string.Join(" ", list);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // 버튼1의 텍스트를 리스트에 추가
            list.Add(button2.Text);

            // 리스트 텍스트 지우고 업데이트
            ListText.Text = string.Join(" ", list);
        }
    }

        private void button3_Click(object sender, EventArgs e)
        {
             list.Add(button3.Text);

        // 리스트 텍스트 지우고 업데이트
             ListText.Text = string.Join(" ", list);

    }

        private void button4_Click(object sender, EventArgs e)
        {
        list.Add(button4.Text);

        // 리스트 텍스트 지우고 업데이트
        ListText.Text = string.Join(" ", list);
    }

        private void button5_Click(object sender, EventArgs e)
        {
        list.remove(button5.Text);

        // 리스트 텍스트 지우고 업데이트
        ListText.Text = string.Join(" ", list);

    }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
