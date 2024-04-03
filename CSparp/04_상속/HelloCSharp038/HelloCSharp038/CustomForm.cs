using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Form 상속 받기 위해 추가

namespace HelloCSharp038
{
    public class CustomForm : Form
    {
        public CustomForm()
        {
            Text = "안녕";
            BackColor = Color.Aqua;
        }
    }
}