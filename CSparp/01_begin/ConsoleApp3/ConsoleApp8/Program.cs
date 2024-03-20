using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list_1 = new List<int>();
            List<int> list_2 = new List<int>();
            List<int> list_3 = new List<int>();
            list_1.Add(1);
            for(var j = 0; j<20; j++)
            {
                int comparingNumber = 0;
                int numberChecker = 1;

                for(var i=0; i<= list_1.Count; i++)
                {
                    if (i != list_1.Count)
                    {
                        list_3.Insert(i, list_1[i]);
                    }
                    else list_3.Add(0);
                }
                for(var i=0; i<list_3.Count; i++)
                {

                    if (i == 0) comparingNumber = list_3[i];
                    else if (comparingNumber == list_3[i])
                    {
                        numberChecker++;
                    }

                }
            }

        }
    }
}
