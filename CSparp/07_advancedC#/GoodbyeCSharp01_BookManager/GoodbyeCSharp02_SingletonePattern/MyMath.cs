using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodbyeCSharp02_SingletonePattern
{
    // 싱글톤 패턴 : 단 한 번만 인스턴스를 선언한 뒤,
    // 그 인스턴스를 여러 클래스에서 공유해서 쓰는 것
    // 이걸 쓰는 이유
    // 1. 메모리 절약 : static이 붙은 클래스 메서드나 클래스 변수에 비해 메모리가 절약
    // 2. static 이 붙은 건 상속이 안 됨(오버라이드 등이 안 됨) -> 인스턴스 메서드를 쓸 수 있다 -> 오버라이드나 상속받기가 가능해 짐
    public class MyMath : Calculator
    {
        //MyMath.Power(5) = 25
        //a.Power(5) = 25, a를 여러 클래스에서 계속 갖다쓰는 거임...

        private static MyMath instance = null;

        //java 스타일
        public static MyMath getInstance()
        {
            if (instance == null)
                instance = new MyMath();
            return instance;
        }

        //c# 스타일 public _getInstance {get;set;} 을 응용
        public static MyMath _getInstance
        {
            get
            {
                if (instance == null)
                    instance = new MyMath();
                return instance;
            }
        }


        private MyMath()
        {

        }

        public int power(int x)
        {
            return x * x;
        }

        public override int minus(int x, int y)
        {
            if (x >= y)
                return base.minus(x, y);
            else
                return y - x;
        }

    }
}
