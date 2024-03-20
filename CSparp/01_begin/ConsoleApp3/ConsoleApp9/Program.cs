using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string start = "1";
                for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i + 1 + "번째 수열:"+start);
                char num = start[0];
                string end = "";
                int count = 0;
                for (int j = 0; j < start.Length; j++)
                {
                    if (start[j]== num)
                        count++;
                    else
                    {
                        end = end + num + count;
                        num = start[j];
                        count = 1;
                    }
                }
                end = end + num + count;
                start = end;
            } 

        }
    }
}
