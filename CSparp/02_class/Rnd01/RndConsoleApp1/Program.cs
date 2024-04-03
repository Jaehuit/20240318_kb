using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RndConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("가위 바위 보 랜덤 게임");

            while (true)
            {
                int computerChoice = new Random().Next(1, 4);
                
            }
        }
    }
}
