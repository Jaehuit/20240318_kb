using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("Text 입력해보세요");
            string text = Console.ReadLine();
            Console.WriteLine("정수 입력해보세요");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num + num);//숫자끼리 덧셈
            Console.WriteLine(text + num);//글자 이어붙이기
        }
    }
}
