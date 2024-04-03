using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //창을 띄우는 유형
            //모달(modal)::다른 화면 조작 불가능, 코드 멈춤
            //모달리스(modeless):: 다른 화면 조작 가능, 코드 멈추지 않음
            MessageBox.Show("경고메시지"); //메시지 박스는 기본적으로 모달
            MessageBox.Show("Test");
            DialogResult result;
            do
            {
                result = MessageBox.Show("다시 시도?", "시도문의", MessageBoxButtons.RetryCancel);
            }while (result == DialogResult.Retry);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            //코드가 멈춰서 Show 호출 안 함
            //창을 닫아야 Show 호출하게 됨
            MessageBox.Show("잠시 숨겼습니다"); //모달을 활용하는 방법 중 하나
            Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            //new Form2("10!=1o").ShowDialog(); //모달, Form2만 보일 것
            new Form2("10!=1o").Show();//모달리스, 창이 둘 다 나타날 것
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;//자기 자신을 Mdi 컨테이너로 만듦
            Form2 f = new Form2();
            f.MdiParent = this; //현재 창을 부모 창으로 지정
            f.Show();
        }
    }
}
