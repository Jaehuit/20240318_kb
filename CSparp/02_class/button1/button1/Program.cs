using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button1
{
    public partial class Form1: Form
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
       
    }

}
