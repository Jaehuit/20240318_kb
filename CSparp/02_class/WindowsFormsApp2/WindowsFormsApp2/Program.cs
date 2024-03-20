using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            myButton.Text = "코드에서 변경!";

            Random random = new Random();
            myButton.Text = random.Next().ToString();
            
            int[] lotto = new int[6];
            int cnt = 0;
            Console.WriteLine("로또 번호: ");
            for (int i = 0; i < lotto.Length; i++)
            {
                Console.WriteLine("cnt: " + (++cnt));
                int num = random.Next(1, 46);
                lotto[i] = num;
                for (int j = 0; j < i; j++)
                {
                    if (lotto[i] == lotto[j])
                    {
                        Console.WriteLine("중복: " + lotto[j]);
                        i--;
                        break;
                    }
                }
                
            }
            for (int i = 0; i < lotto.Length; i++)
            {
                Console.WriteLine(lotto[i] + " ");

            }
        }
   
        
    }
}
