using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("인치를 입력하세요:");
            double inches = double.Parse(Console.ReadLine());
            double centimeters = inches * 2.54;
            Console.WriteLine("원의 반지름을 입력 받아 원의 둘레와 넓이를 구하세요");
            Console.WriteLine();
            string test = Console.ReadLine();
            int inch = int.Parse(Console.ReadLine());
            Console.WriteLine($"{inch}inch={inch*2.54}cm");
            Console.WriteLine(inch+"inch="+(inch*2.54)+"cm");
            Console.WriteLine(string.Format("{0}inch={1}cm",inch,inch*2.54));
            
            Console.WriteLine(10+2+"100"); //12100
            Console.WriteLine(10 + "100" + 2); //101002
            Console.WriteLine(10+2 + "100" + 2+4); //1210024
            //먼저 더해야 하거나 연산 순서가 애매하면 무조건 괄호로 묶을 것


        }
    }
}
