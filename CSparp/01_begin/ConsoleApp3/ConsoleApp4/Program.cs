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
            Console.WriteLine("1부터 100까지의 모든 정수를 더한 결과: " + sum);

            //for 반복문을 사용하여 한글 전부 출력하기


            int[] nums = { 11, 10, 50, 27, 30 };
            //nums라는배열 안에 있는 값들을 하나씩 item에 넣어 nums의 길이만틈 반복문을 수행하는 것
            //foresch(var요소 in 컬렉션) {}
            //컬렉션 = 배열이나 List와 같이 여러 개의 값을 저장하는 것 
            foreach(var item  in nums) 
            Console.WriteLine(item);

            Console.WriteLine("숫자 입력");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
               // goto StartPos;
            Console.WriteLine("프로그램 종료");

        }
    }
}
