using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp053
{
    public class Program
    {
        //반환형이 없고 매개변수가 Product 한 개인 자료형
        delegate void printProduct(Product p);
        static void printObject(printProduct pp, Product p,int count)
        {
            for(int i = 0; i < count; i++) { pp(p); }
        }

        static int mypriceCompare(Product a, Product b)
        {
            return a.Price.CompareTo(b.Price);
        }

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product() { Name="감자",Price=3000},
                new Product() { Name = "사과", Price = 5000 },
                new Product() { Name = "고구마", Price = 4000 },
                new Product()  {Name = "당근", Price = 2000}
                //products.Sort(); 배열의 두 요소를 비교하지 못함
            };
            products.Sort(mypriceCompare);

            //public delegate int Comparison<in T>(T x, T y):
            //Sort(Comaprison<Product>)com);

            products.Sort(delegate (Product a, Product b) { return a.Price.CompareTo(b.Price);  });

           //람다식:: products.Sort (a, b) => { return a.Price.CompareTo(b.Price); });

            foreach (var item in products)
            {
                Console.WriteLine(item.Name + ":" + item.Price);
            }
        }
    }
}
