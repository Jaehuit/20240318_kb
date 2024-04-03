using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp034
{
    internal class Program
    {
        public int Power(int input)
        {
            return input * input;
        }
        public int Power(int input, int count)
        {
            int result = 1;
            for (int i = 0; i < count; i++)
                result *= input;
            return result;
        }
        static int sumAll(int end)
        {
            int sum = 0;
            for (int i = 0; i <= end; i++)
                sum += i;
            return sum;
        }
        static int sumAll(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
                sum += i;
            return sum;
        }

        static void Main(string[] args)
        {
            int a = new Program().Power(10);
            Console.WriteLine(a);
            a = new Program().Power(2, 5);
            Console.WriteLine(a);
            Console.WriteLine(sumAll(10));
            Console.WriteLine(Program.sumAll(10));
            Console.WriteLine(sumAll(5, 10));
            Console.WriteLine(Program.sumAll(5, 10));

            MyMath m = new MyMath();
            Console.WriteLine(m.sumAll(100));
            Console.WriteLine(m.sumAll(50, 100));
            Console.WriteLine(MyMath.Power(5));
            Console.WriteLine(MyMath.Power(5, 3));

        }
    }
}
