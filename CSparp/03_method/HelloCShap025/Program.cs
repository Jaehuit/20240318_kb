using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCShap025
{
    internal class Program
    {
        //오버로딩: 매개변수의 개수나 타입이 다르면 함수(=매서드) 이름이 같아도 서로 다른 것으로 간주
        static void introduce(int age)
        {
            Console.WriteLine("내나이는"+age+"살입니다");
        }
        static void introduce(string name)
        {
            Console.WriteLine("내 이름은"+name+"입니다");
        }


        static void Main(string[] args)
        {
            introduce(35);
            introduce("이동준");
            Rectangle.color = "파란색";
            Rectangle rec1 = new Rectangle();
            rec1.width = 10;
            rec1.height = 10;
            Rectangle rec2 = new Rectangle();
            rec2.width = 5;
            rec2.height = 5;

            Console.WriteLine(rec1.getArea());
            Console.WriteLine(rec2.getArea());
            Console.WriteLine(Rectangle.calcRecArea(100, 200));

            Product p1 = new Product(" 고구마", 500);
            Console.WriteLine(p1.name + "의 가격:" + p1.price);
            Product p2 = new Product(" 대게");

        }
    }
}
