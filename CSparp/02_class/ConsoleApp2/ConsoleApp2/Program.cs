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
            Random random = new Random();

            int[] lotto = new int[6];
            int cnt = 0;
            Console.WriteLine("로또 번호: ");
            for (int i = 0; i < lotto.Length; i++)
            {
               // Console.WriteLine("cnt: " + (++cnt));
                int num = random.Next(1, 46);
                lotto[i] = num;
                for (int j = 0; j < i; j++)
                {
                    if (lotto[i] == lotto[j])
                    {
                        Console.WriteLine("중복: " + lotto[j]);
                        i--;
                        break;
                    }
                }

            }
            for (int i = 0; i < lotto.Length; i++)
            {
                Console.WriteLine(lotto[i] + " ");

            }
        }
    }
}
