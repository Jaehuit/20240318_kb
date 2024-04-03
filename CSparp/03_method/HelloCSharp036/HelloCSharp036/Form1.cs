using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp036
{
    public partial class Form1 : Form
    {
        int answer = 0; //정답
        int count = 1; //버튼의 수
        int limit = 0; //한계 시간
        int nowTime = 0; //현재 시간
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            timer1.Interval = 1000;
            button1.Click += startButton; //클릭할 때 수행할 것
            timer1.Tick += gameTimer; //1초에 한 번 수행할 것
        }
        private void startButton(object s, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button btn = new Button();
                    Point p = new Point();
                    p.X = 15 + 100 * j;
                    p.Y = 15 + 15 + 25 * i;
                    btn.Location = p;
                    btn.Click += Btn_Click;
                    btn.Text = count + "";
                    count++;
                    Controls.Add(btn);
                }
            }
            label1.Text = "";
            answer = new Random().Next(25) + 1;//1~25
            limit = int.Parse(textBox1.Text);
            nowTime = 0;
            timer1.Enabled = true; //타이머가 시작됨
            Console.WriteLine(answer);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button nowBtn = (Button)sender;
            if (int.Parse(nowBtn.Text) == answer)
            {
                label1.Text = "정답!";
                timer1.Enabled = false;
            }
        }

        private void gameTimer(object s, EventArgs e)
        {
            nowTime++;
            if (nowTime >= limit)
            {
                label1.Text = "GameOver!";
                //timer1.Enabled = false;
                ((Timer)(s)).Enabled = false;
                return; //메서드 종료
            }
            label1.Text = nowTime + "/" + limit;
        }
    }
}
