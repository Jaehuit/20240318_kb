using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(n<=0)
                return;
            string currentSequence = "1";
            string nextSequence = new string();

            for(int i =2; i <= n; i++)
            {
                int count = 1;
                char currentNumber = currentSequence[0];

                for(int j = 1; j < currentSequence.Length; j++) 
                { 
                    if (currentSequence[j] == currentNumber)
                        count++;
                    else
                    {
                        
                    }
                }
            }

        }
    }
}
