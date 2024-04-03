using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodbyeCSharp03_ObserverPattern
{
    public partial class Form3 : Form,IObserver
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(ISubject sub)
        {
            InitializeComponent();
            sub.register(this); //Form1에 있는 register를 호출함
        }

        public void update(string value)
        {
            textBox1.Text =  value;
        }
    }

    
}
