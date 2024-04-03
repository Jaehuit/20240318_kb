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
    public partial class Form1 : Form, ISubject
    {
        List<IObserver> observers = new List<IObserver>();
        public Form1()
        {
            InitializeComponent();
            textBox1.TextChanged += TextBox1_TextChanged;
            
            Form2 frm2 = new Form2(this);  //this = Form1 = ISubject 구현한 객체
            frm2.TopLevel = false;    // 이거 없으면 에러 뜸
            frm2.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(frm2);
            frm2.Show();

            Form3 frm3 = new Form3(this);
            frm3.TopLevel = false;
            frm3.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm3);
            frm3.Show();

            Form4 frm4 = new Form4(this, frm2, frm3);
            frm4.TopLevel = false;
            frm4.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(frm4);
            frm4.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            notify((sender as TextBox).Text);
        }

        public void notify(string msg)
        {
            foreach (IObserver item in observers)
                item.update(msg);
        }

        public void register(IObserver o)
        {
            observers.Add(o);
        }

        public void unregister(IObserver o)
        {
            observers.Remove(o);
        }
    }
}