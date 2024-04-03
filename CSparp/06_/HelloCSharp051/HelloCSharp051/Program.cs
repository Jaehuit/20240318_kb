using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp051
{
    internal class Program
    {
        delegate void voidFunc();
        static void testMethod()
        {
            Console.WriteLine("test");
        }
        static void doFunc(voidFunc v, int count)
        {
            for (int i = 0; i < count; i++)
                v();
        }

        static void Main(string[] args)
        {
            testMethod();
            doFunc(testMethod, 3);
            doFunc(delegate() { Console.WriteLine("------"); },3);
            doFunc(()=> { Console.WriteLine("@@@@"); },3);    

            voidFunc v1 = delegate() { Console.WriteLine("안녕"); };
            voidFunc v2 = () => { Console.WriteLine("Hi"); };
        }
    }
}
