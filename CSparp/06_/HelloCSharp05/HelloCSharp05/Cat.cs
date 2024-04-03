using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    public class Cat : Animal
    {
        public override void cry()
        {
            Console.WriteLine("야옹야옹");
        }

        public override void eat()
        {
            Console.WriteLine("뇸뇸뇸");
        }

        public override void sleep()
        {
            Console.WriteLine("그르릉zZZ...");
        }
    }
}
