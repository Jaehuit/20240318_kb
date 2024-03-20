using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp02
{
    internal class Program
    {
        //static 없으면 사용 불가
        //static이 붙어있는 메서드 안에는 static이 붙은 메서드나 변수만 사용 가능
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
        }
        void HiWorld()
        {
            Console.WriteLine("HiWorld");
        }
        static int count = 0;
        int number = 0;
        static void Main(string[] args)
        {

            Console.WriteLine(count);
            new Program().HiWorld();
            //굳이 static 없는 걸 Main에서 쓰고 싶다면 자기 자신을 객체화 해야함
            Product p1 = new Product();
            Product p2 = new
            p1.Name = "감자";
            p2.price = 1000;
            Product.countOfProduct++;

            Console.WriteLine(p1.name);
            Console.WriteLine(p1.name);
            Console.WriteLine(p2.price);
            Console.WriteLine(p2.price);
            Console.WriteLine(Product.countOfProduct);

        }
    }
}
