using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                
                int[] numbers = new int[5];

                // 사용자로부터 숫자 입력 받기
                for (int i = 0; i < 5; i++)
                                                 //for(int i = 0; i<numbers.Length; i++)
                {
                    Console.Write($"숫자를 입력하세요 ({i + 1}/5): ");
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                // 최소값과 최대값 찾기
                int minNumber = numbers[0];
                int maxNumber = numbers[0];

                foreach (var num in numbers)
                                                  //for(int i=1; i<numbers.Length; i++)
                {
                    if (num < minNumber)          //if(minNumber < numbers[i])
                        minNumber = num;          //   minNumber = numbers[i];
                    if (num > maxNumber)          //if(maxNumber < numbers[i])
                        maxNumber = num;          //   maxNumber = numbers[i];
                }

                // 결과 출력
                Console.WriteLine($"가장 작은 수: {minNumber}");    //Console.WriteLine("Max: " +maxNumber);
                Console.WriteLine($"가장 큰 수: {maxNumber}");      //Console.WriteLine("Min: " +minNumber);


            }
        
        }
    }
}
