using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp037
{
    public abstract class Food  //추상화된 클래스
        //Food만으로는 인스턴스 못 만듦
        //추상화 = 구체화를 못한다 = 인스턴스 못 만든다
        //Food f = new Food();
    {
        public string name {  get; set; }
        public int price { get; set; }

        //시식을 추상화
        public abstract void taste();
        //Food를 상속받은 클래스에서 이 메서드를 구체화해야함
        //음식마다 시삭하는 방법이 다르기 때문에
    }
}
