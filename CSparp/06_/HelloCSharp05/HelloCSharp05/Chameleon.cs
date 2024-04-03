using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    public class Chameleon : Reptilia
    {

        public string color { get; set; }
        public void changeColor(string color)
        {
            if (color.Equals("투명색")) //투명한 색으로는 변신 불가능
                this.color = "초록색";
            else if (color.Equals("디지털군복색깔"))
                this.color = "투명색";
            else
                this.color = color;
        }
        public override void creep()
        {
            Console.WriteLine("눈알을 굴리며 조심히 기어갑니다.");
        }

        public override void crwal()
        {
            Console.WriteLine("조금 빨리 기어갑니다.");
        }

        public override void cry() //카멜레온은 울지 않음
        {
            // Console.WriteLine("........");
            //throw new NotImplementedException();
        }

        public override void eat()
        {
            Console.WriteLine("혀를 날름 거리며 먹습니다.");
        }

        public override void sleep()
        {
            Console.WriteLine("........");
        }
    }
}

