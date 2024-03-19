using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("태어난 해를 입력하세요.");
            int birthYear = int.Parse(Console.ReadLine()); ;

            if (birthYear % 12 == 0)
                Console.WriteLine("쥐");

            else if (birthYear % 12 == 1)
                Console.WriteLine("소");
            else if (birthYear % 12 == 2)
                Console.WriteLine("호랑이");
            else if (birthYear % 12 == 3)
                Console.WriteLine("토끼");
            else if (birthYear % 12 == 4)
                Console.WriteLine("용");
            else if (birthYear % 12 == 5)
                Console.WriteLine("뱀");
            else if (birthYear % 12 == 6)
                Console.WriteLine("말");
            else if (birthYear % 12 == 7)
                Console.WriteLine("양");
            else if (birthYear % 12 == 8)
                Console.WriteLine("원숭이");
            else if (birthYear % 12 == 9)
                Console.WriteLine("닭");
            else if (birthYear % 12 == 10)
                Console.WriteLine("개");
            else
                Console.WriteLine("돼지");

            birthYear = DateTime.Now.Year % 12;
            Console.WriteLine("올해는 띠 입니다");


            Console.WriteLine("몇월에 태어났나요");
            int month = int.Parse(Console.ReadLine());
            if (month == 12 || month == 1 || month == 2)
                Console.WriteLine("겨울");
            else if (month >= 3 && month <= 5)
                Console.WriteLine("봄");
            else if (month >= 6 && month <= 8)
                Console.WriteLine("여름");
            else if (month >= 9 && month <= 11)
                Console.WriteLine("가을");
            else
                Console.WriteLine("?");

            month = DateTime.Now.Month;
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;
                default:
                    Console.WriteLine("?????????");
                    break;
            }



        }
    }
}
