using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    public class Ivysaur : Bulbasaur
    {
        public override void cry()
        {
            Console.WriteLine("풀풀 이상해풀~");
        }
        public override void fight()
        {
            Console.WriteLine("꽃봉오리로도 때리지 마라");
        }
    }
}