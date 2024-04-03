using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp054
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Text = "버튼";
            btn.Click += myevent;
            btn.Click += delegate (object s, EventArgs e)
            {
                MessageBox.Show("두번째 이벤트");
            };
            btn.Click += (s, e) =>
            {
                MessageBox.Show("세번째 이벤트");
            };
            Controls.Add(btn);

            Button btn2 = new Button();
            btn2.Text = "버튼의 이벤트 빼기";
            btn2.AutoSize = true;
            btn2.Location = new Point(100, 100);
            btn2.Click += delegate (object s, EventArgs e) {
                btn.Click -= myevent;
            };

            Button btn3 = new Button();
            btn3.Text = "버튼의 이벤트 추가";
            btn3.AutoSize = true;
            btn3.Location = new Point(100, 200);
            btn3.Click += delegate (object s, EventArgs e) {
                btn.Click += myevent;
            };

            Controls.Add(btn2);
            Controls.Add(btn3);

        }

        private void myevent(object sender, EventArgs e)
        {
            MessageBox.Show("첫번째 이벤트");

        }
    }
}
