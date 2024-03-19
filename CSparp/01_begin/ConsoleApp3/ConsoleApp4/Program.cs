using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            // for 반복문을 사용하여 1부터 100까지의 정수를 더함
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }

            // 덧셈 결과 출력
            Console.WriteLine("1부터 100까지의 모든 정수를 더한 결과: " + sum);





        }
    }
}
