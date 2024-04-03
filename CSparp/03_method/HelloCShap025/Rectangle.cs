using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCShap025
{
    public class Rectangle
    {
        public int width { get; set; }
        public int height { get; set; }
        public static string color {  get; set; } // 모두 색깔은 같다고 가정하자

        public int getArea() { return width*height; } //getArea

        public static int calcRecArea(int w, int h) { return w*h; }

        
    }
}
