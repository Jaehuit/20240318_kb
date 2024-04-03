using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HelloCSharp052
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product() { Name="감자",Price=3000},
                new Product() { Name = "사과", Price = 5000 },
                new Product() { Name = "고구마", Price = 4000 }

            };

            products.Sort(delegate (Product a, Product b)
           {
               return a.Price.CompareTo(b.Price);
           });
            foreach(var item in products)
            {
                Console.WriteLine(item.Name + ":" + item.Price);
            }
        }
    }

