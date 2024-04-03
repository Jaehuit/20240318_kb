using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp055
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

            //만약 짝수만 가져고오고 싶다면?

            List<int> evenNum = new List<int>();
            foreach (var item in nums)
            {
                if(item%2==0) evenNum.Add(item);
            }

            //LINQ = 컬렉션(=배열이나 List)에 있는 값을 SQL 형식으로 가져오는 문법
            // from 요소이름(=임의변수이름) in 컬렉션명 where 조건 select 가져올 값;

            var evenNum2 = from item in nums where item %2==0 select item;  

            foreach(var item in evenNum)
                Console.WriteLine(item);
            foreach(var item in evenNum2)
                Console.WriteLine(item);

            List<int> powerNum = new List<int>();   
            foreach(var item in nums)
                powerNum.Add(item*item);
            foreach(var item in powerNum)
                Console.WriteLine(item);

            var powerNum2 = from item in nums select item*item;
            foreach (var item in powerNum2)
                Console.WriteLine(item);

            List<int> myeven = evenNum.ToList();
            List<int> mypower = powerNum2.ToList();

            List<int> oddNum = (from item in nums where item % 2 != 0 select item).ToList<int>();
            foreach (var item in oddNum)
                Console.WriteLine(item);

            var powerEvenOutput = from item in nums
                                  where item % 2 == 0
                                  select new
                                  {
                                      num = item,
                                      doubleNum = item * 2,
                                      powerNum = item * item
                                  };
            foreach (var item in powerEvenOutput)
            {
                Console.WriteLine(item.num+",",item.doubleNum+","+item.powerNum);    
            }
            List<Product> products = new List<Product>();
            products.Add(new Product { name = "고구마", price = 5000 });

            var myproducts = from item in products
                             where item.price > 5000
                             orderby item.name ascending
                             select item;
            List<Product> vipProducts = (from item in products
                                       where item.price > 5000
                                       orderby item.name ascending
                                       select item).ToList<Product>();
            foreach (var item in myproducts)
            {
                Console.WriteLine(item.ToString()); }

             foreach (var item in vipProducts)
                {
                Console.WriteLine(item.ToString());
             }
            foreach (Product item in myproducts)
            {
                Console.WriteLine(item.ToString());
            }

            foreach (Product item in vipProducts)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
