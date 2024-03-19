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
            int a = 35;
            double b = 3.14;
            char c = 'A';
            string d = "이동준";//string 과 String 동일함
            String d2 = "이유나";
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine("안녕하세요"[0]); //java의 get
            Console.WriteLine("Text 입력해보세요");
            string text = Console.ReadLine();
            Console.WriteLine("정수 입력해보세요");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num + num);//숫자끼리 덧셈
            Console.WriteLine(text + num);//글자 이어붙이기
           
            
            Console.WriteLine("원의 반지름을 입력 받아 원의 둘레와 넓이를 구하세요");
            Console.WriteLine();
            string test = Console.ReadLine();
            int inch = int.Parse(Console.ReadLine());
            Console.WriteLine($"{inch}inch={inch * 2.54}cm");
            Console.WriteLine(inch + "inch=" + (inch * 2.54) + "cm");
            Console.WriteLine(string.Format("{0}inch={1}cm", inch, inch * 2.54));

            Console.WriteLine(10 + 2 + "100"); //12100
            Console.WriteLine(10 + "100" + 2); //101002
            Console.WriteLine(10 + 2 + "100" + 2 + 4); //1210024
            //먼저 더해야 하거나 연산 순서가 애매하면 무조건 괄호로 묶을 것

            //int.Parse("123") -> 123, 문자열을 정수로 바꿔주는 함수
            //double.Parse("3.14") -> 3.14 문자열을 실수로 바꿔주는 함수
            Console.WriteLine("몇 Kg?");
            int kg = int.Parse(Console.ReadLine());
            Console.WriteLine($"{kg}kg={2.20462262*kg}pound");

            Console.WriteLine("원의 반지름을 입력하세요");
            const double PI = 3.14;
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("둘레:" + (2 * PI * r));
            Console.WriteLine("넓이:" + (r * r * PI));

        }
    }
}
