using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    //추상 클래스 : 구체적이지 않은 클래스
    //대략적인(=꼭 오버라이드로 구현해야 하는) 메서드들만 추가
    //자고로 동물이라 하면은 자는 것, 먹는 것, 우는 것이 다 다를 것이다.
    //그러므로 그 부분은 꼭 정의를 해줬으면 좋겠다!
    public abstract class Animal
    {
        public string name { get; set; }
        public string description { get; set; }

        public abstract void sleep();
        public abstract void eat();
        public abstract void cry();
    }
}