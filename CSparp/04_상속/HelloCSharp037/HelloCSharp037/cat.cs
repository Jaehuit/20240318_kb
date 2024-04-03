using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp037
{
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("야옹");
        }
        public void Eat() 
        {
            Console.WriteLine("고양이스럽게 먹는다");
        }
        public override void Charm() 
        {
            Console.WriteLine("집사 잘했네.쓰담쓰담");
        }
        public new void Cry()
        {
            Console.WriteLine("집사 이럴줄 몰랐어");
        }
    }
}