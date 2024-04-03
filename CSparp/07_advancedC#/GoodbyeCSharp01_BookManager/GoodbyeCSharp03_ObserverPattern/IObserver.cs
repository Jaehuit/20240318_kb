using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodbyeCSharp03_ObserverPattern
{
    public interface IObserver  // 관찰자의 역할 정의
    {
        void update(string value);
    }
}
