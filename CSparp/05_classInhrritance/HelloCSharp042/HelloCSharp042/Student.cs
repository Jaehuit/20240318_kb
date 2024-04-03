using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp042
{
    //제너릭
    //T 대신 다른 문자 넣어도 됨
    //특정 속성의 타입을 정하지 못할 경우
    //임의의 문자로 타입을 지정하고
    //인스턴스 생성시 그 때 타입을 정하는 방식
    //가장 대표적인 예시 List
    //ex. Student<int> s 하면 학번은 정수가 됨
    //Student<string> s 하면 학번은 문자열이 됨
    public class Student<T>
    {
        public T hakbeon { get; set; }
        public string name { get; set; }
    }
}