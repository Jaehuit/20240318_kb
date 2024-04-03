using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    public interface IPokemon
    {
        int age { get; set; } //포켓몬이라면 나이를 가지고 있음
                              //대신 이게 인터페이스게 들어가면
                              //이 get과 set 부분도 직접 구현해야 함
        string ability { get; set; } //특성, 포켓몬마다 다름
        void fight();
        void charming();

    }
}
