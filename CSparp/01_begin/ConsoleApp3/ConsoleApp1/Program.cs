using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
        }
    }
}
