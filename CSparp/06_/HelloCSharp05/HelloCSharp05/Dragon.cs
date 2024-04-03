using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    public abstract class Dragon : ICreatures
    {
        //public virtual int castMagic(string name)
        //{
        //    throw new NotImplementedException();
        //}
        public abstract int castMagic(string name);

        public abstract void fly();

        public abstract void polymorp(string name);

        public abstract void sayHello();
    }
}