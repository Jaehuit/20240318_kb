using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp037
{
    public class Dog : Animal //Animal을 상속받음
    {
        public string hairColor { get; set; }
        public void Bark()
        {
            Fight();//Animal을 상속받았으므로 사용 가능
            Console.WriteLine("멍멍 짖는다.");
            //Run(); //Animal 안에서만 호출 됨
        }
        public void Eat()
        {
            Console.WriteLine("개스럽게 먹는다");
        }
        public override void Charm()
        {
            Console.WriteLine("사랑해영");
        }
        public new void Cry()
        {
            Console.WriteLine(" 이럴줄 몰랐어 bb");
        }

    }
}