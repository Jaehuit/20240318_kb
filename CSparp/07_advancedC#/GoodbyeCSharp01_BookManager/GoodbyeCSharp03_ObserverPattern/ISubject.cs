using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodbyeCSharp03_ObserverPattern
{
    public interface ISubject //관찰자들을 관리
    {
        //subscribe, dissubscribe or unsubscribe
        void register(IObserver o); //객체 등록(관찰자 등록)
        void unregister(IObserver o); //객체 해제(관찰자 삭제)
        void notify(string msg); //관찰자들에게 일괄적으로 전달
    }
}
