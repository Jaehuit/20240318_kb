using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    public interface ICreatures : IFantasy, IBirds
    {
        void sayHello(); //인사하는 기능
    }
}
