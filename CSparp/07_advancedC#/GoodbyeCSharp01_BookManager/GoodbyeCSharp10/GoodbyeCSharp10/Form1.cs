using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodByeCSharp10_mapAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //textBox1에서 키를 눌렀다가 그 키가 올라올 때 호출할 메서드 지정
            textBox1.KeyUp += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) //누른 키가 Enter키 일 때만 이벤트 호출
                    button1.PerformClick(); //버튼1 클릭하는 이벤트 호출
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Locale> locales = KakaoAPI.Search(textBox1.Text);
            listBox1.Items.Clear();
            foreach (Locale item in locales)
                listBox1.Items.Add(item);
        }

        //해당 키워드 클릭시 setCenter 호출
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;
            Locale ml = listBox1.SelectedItem as Locale;
            object[] pos = new object[] { ml.Lat, ml.Lng };
            HtmlDocument hdoc = webBrowser1.Document;
            hdoc.InvokeScript("setCenter", pos); //setCenter 호출하고 매개변수는 pos
        }
    }
}
