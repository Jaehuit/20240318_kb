using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rnd01
{
    internal static class Program
    {
       static void Main(string[] args)
    {
        Console.WriteLine("가위바위보 게임을 시작합니다!");

        while (true)
        {
            Console.WriteLine("\n가위(1), 바위(2), 보(3) 중 하나를 선택하세요. (종료: 0)");
            Console.Write("선택: ");
            string userInput = Console.ReadLine();

            if (userInput == "0")
            {
                Console.WriteLine("게임을 종료합니다.");
                break;
            }

            if (userInput != "1" && userInput != "2" && userInput != "3")
            {
                Console.WriteLine("잘못된 입력입니다. 다시 입력하세요.");
                continue;
            }

            int userChoice = int.Parse(userInput);
            int computerChoice = new Random().Next(1, 4);

            string[] choices = { "가위", "바위", "보" };
            string userChoiceStr = choices[userChoice - 1];
            string computerChoiceStr = choices[computerChoice - 1];

            Console.WriteLine($"사용자: {userChoiceStr}");
            Console.WriteLine($"컴퓨터: {computerChoiceStr}");

            if (userChoice == computerChoice)
            {
                Console.WriteLine("비겼습니다!");
            }
            else if ((userChoice == 1 && computerChoice == 3) || 
                     (userChoice == 2 && computerChoice == 1) || 
                     (userChoice == 3 && computerChoice == 2))
            {
                Console.WriteLine("사용자가 이겼습니다!");
            }
            else
            {
                Console.WriteLine("컴퓨터가 이겼습니다!");
            }
        }
    }
    }
}
