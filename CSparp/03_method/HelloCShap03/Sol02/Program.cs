using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//int power(int input):매개변수 input을 제곱해서 반환하는 매서드
//int power(int input, int count):매개변수 input을 카운트만큼 제곱해서 반환하는 매서드
//int SumAll(int end):0부터 end 사이의 모든 정수를 더하는 메서드
//int SumAll(int start, int end): start부터 end 사이의 모든 정수를 더하는 메서드
namespace Sol02
{
    public class Program
    {
        public int Power(int input)
        {
            return input * input;
        }

       
        static int Power1(int input)
        {
            return input * input;
        }

        static int Power1(int input, int count)
        {
            int result = input;
            for (int i = 1; i < count; i++)
            {
                result *= input;
            }
            return result;
        }
        static int SumAll(int end)
        {
            return (end * (end + 1)) / 2;
        }
        static int SumAll1(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine("제곱 결과: " + Power1(num));
            int count = 3;
            Console.WriteLine($"{num}의 {count}제곱 결과: " + Power1(num, count));
            int end = 10; 
            Console.WriteLine($"0부터 {end}까지의 합: " + SumAll(end));
            int start = 3;
            Console.WriteLine($"{start}부터 {end}까지의 합: " + SumAll1(start, end));
        }
    }
}
