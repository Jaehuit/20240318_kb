using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    //Animal을 상속받았다는 것은
    //sleep eat cry를 반드시 구현해야 한다는 의무를 부과한 것
    public class Dog : Animal
    {
        public override void cry()
        {
            Console.WriteLine("멍멍멍");
        }

        public override void eat()
        {
            Console.WriteLine("촵촵촵");
        }

        public override void sleep()
        {
            Console.WriteLine("zZzZ.....");
        }
    }
}
