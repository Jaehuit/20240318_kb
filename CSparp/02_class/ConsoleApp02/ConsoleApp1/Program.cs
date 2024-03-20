using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class product
      
    {
       public string name { get; set; }      //getter, setter 축약
       public int price {  get; set; }       //인스턴트 변수, 인스턴스 별로 값이 다름
       public static int countOfProduct = 0; //클래스 변수 클래스 공통 값

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
