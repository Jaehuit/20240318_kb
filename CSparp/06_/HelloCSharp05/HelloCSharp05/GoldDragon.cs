using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    public class GoldDragon : Dragon
    {
        public override int castMagic(string name)
        {
            Console.WriteLine("주문 없이 마법을 바로 쓸 수 있음");
            Console.WriteLine("마법 이름 : " + name);
            return 100; //데미지, 상대의 속성에 관계없이 고정 데미지가 들어감
        }

        public override void fly()
        {
            Console.WriteLine("날개짓 없이 마법으로 보통 날아댕김");
        }

        public override void polymorp(string name)
        {
            Console.WriteLine("변신 : " + name);
        }

        public override void sayHello()
        {
            Console.WriteLine("...(골드 드래곤은 자신보다 하등한 자에게 인사하지 않는다)");
        }
    }
}
