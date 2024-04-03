using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloCSharp052
{
    internal class Program
    {
        static void printA()
        {
            for (int i = 0; i < 100; i++)
                Console.Write("A");
        }
        static void Main(string[] args)
        {
            //Thread는 비동기 방식으로 동작을 함
            //앞선 메서드가 다 동작을 하지 않더라도 시분할을 적용하여(시간을 분할)
            //각자 시간이 될 때 알아서 실행
            //동기 방식 : A를 100번 출력 다 하고 나서 B 100번 출력 그리고 나서 C 100번 출력
            //비동기 : A를 출력하다가 B도 출력하다가 C도 출력하는 방식
            Thread t1 = new Thread(printA);
            Thread t2 = new Thread(delegate ()
            {
                for (int i = 0; i < 100; i++)
                    Console.Write("B");
            });
            Thread t3 = new Thread(() =>
            {
                for (int i = 0; i < 100; i++)
                    Console.Write("C");
            });
            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
