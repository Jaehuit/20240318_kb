using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCShap032
{
    internal class Program
    {
        static Dictionary<int, long> memo = new Dictionary<int, long>();
        static long Fibo(int i)   //재귀함수
        {
            if (i <= 0)
                return 0;
            if (i == 1)
                return 1;
            return Fibo(i - 2) + Fibo(i - 1);
        }
        static long Fibonacci(int i)   //Dictionary memo(HashMap) 
        {
            if (i <= 0)
                return 0;
            if (i == 1)
                return 1;
            if (memo.ContainsKey(i))
                return memo[i];
            else
            {
                long value = Fibonacci(i - 2) + Fibonacci(i - 1);
                memo[i] = value;
                return value;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString("mm분ss초fff"));
            Console.WriteLine(Fibonacci(100));
            Console.WriteLine(DateTime.Now.ToString("mm분ss초fff"));
            Console.WriteLine(Fibo(100));
            Console.WriteLine(DateTime.Now.ToString("mm분ss초fff"));
            Console.WriteLine(Fibonacci(100));
            Console.WriteLine(DateTime.Now.ToString("mm분ss초fff"));
        }
    }
}
