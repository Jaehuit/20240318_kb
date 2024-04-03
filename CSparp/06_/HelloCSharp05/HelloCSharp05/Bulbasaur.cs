using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    public class Bulbasaur : Animal, IPlant, IPokemon
    {
        private int pAge;

        //age부분처럼 if문을 한 줄로 적는 건 비권장 문법
        //가독성이 매우 떨어지므로 if문이 있으면 두 줄 이상으로 분리를 해주는 게 좋다.
        public int age { get { return pAge; } set { if (value < 0) pAge = 0; else pAge = value; } }
        public string ability { get; set; }

        public virtual void bearFruit()
        {
            Console.WriteLine("아직 그런 거 없어요.");
        }

        public virtual void blooming()
        {
            Console.WriteLine("꽃 봉오리도 없음 ㅇㅇ");
        }

        public void charming()
        {
            Console.WriteLine("이상해씨는 그냥 귀여움");
        }

        public  override void cry()
        {
            Console.WriteLine("씨씨씨 이상해씨");
        }

        public override void eat()
        {
            Console.WriteLine("덩쿨로 냠냠");
        }

        public virtual void fight() //이상해씨를 상속받을 경우 fight는 오버라이드 가능
        {
            Console.WriteLine("덩쿨로 후드려 팸");
        }

        public virtual void photosynthesis() //인터페이스에서 온 메서드
        {
            Console.WriteLine("봉오리 끝에서 햇빛을 흡수함");
        }

        public override void sleep() //추상클래스에서 온 메서드
        {
            Console.WriteLine("뒤집어져서 자기도 함");
        }
    }
}