using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp034
{
    public class MyMath
    {
        public static int Power(int input)
        {
            return input * input;
        }
        public static int Power(int input, int count)
        {
            int result = 1;
            for (int i = 0; i < count; i++)
                result *= input;
            return result;
        }
        public int sumAll(int end)
        {
            int sum = 0;
            for (int i = 0; i <= end; i++)
                sum += i;
            return sum;
        }
        public int sumAll(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
                sum += i;
            return sum;
        }
    }
}
