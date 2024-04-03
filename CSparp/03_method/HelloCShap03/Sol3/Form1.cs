using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol3
{
    //타이머를 추가하여 보물 찾기 게임을 만드시오.(지뢰찾기)
    //특정 버튼을 눌러야지만 게임에 승리

    public partial class Form1 : Form
    {
        int mytime = 0;
        const int LIMIT = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
