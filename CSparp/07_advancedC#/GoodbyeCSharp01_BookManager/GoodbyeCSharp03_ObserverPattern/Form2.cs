using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodbyeCSharp03_ObserverPattern
{
    public partial class Form2 : Form,IObserver
    {
        public Form2()
        {
            InitializeComponent();
        }
        //ISubject를 구현한 객체가 가지고 있는 register를 호출함
        public Form2(ISubject sub)//현재는 ISubject를 구현한 객체 = Form1
        {
            InitializeComponent();
            sub.register(this); //Form1에 있는 register를 호출함
        }

        public void update(string value)
        {
            label1.Text = "옵저버 패턴에 의한 변경 메시지 : " + value;
        }
    }
}
