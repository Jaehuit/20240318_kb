using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HelloCShap03
{
    internal class Program
    {
        static void change(int input)
        {
            input++;
        }
        //믈래스 말고 배열이나 list도 똑같이 참조복사 개념 적용됨
        //참고로 구조체(struct)는 일반 자료형처럼 값 복사 개념 적용됨
        static void change(Student student)
        {
            student.name = "이주섭";
            student.score = 90;
            student.age = 20;
        }

        static void change(ref int input)
        {
            input++;
        }
        static void Main(string[] args)
        {
            
            int a = 10;
            int b = a;
            b = 20;
            Console.WriteLine("a="+a+",b="+b); //서로 영향 없음
            change(a);
            Console.WriteLine("a="+a);

            Student s = new Student();  
            s.name = "권성직";
            s.age = 40;
            s.score = 150;

            Student s2 = new Student();
            s2.name = "이유탁";
            s.age = 20;
            s2.score = 1000;
            Console.WriteLine(s.name + "," +s.age+","+ s.score);
            Console.WriteLine(s2.name + "," +s2.age+","+ s2.score);

            Student dj = s;       //바로가기
            dj.name = "이동준";
            dj.age = 20;
            dj.score = 50;

            Console.WriteLine(s.name + "," + s.age + "," + s.score);
            Console.WriteLine(dj.name + "," + dj.age + "," + dj.score);

            change(s);
            Console.WriteLine(s.name+ "," + s.age + "," + s.score);

            Console.WriteLine("a="+a);
            change(ref a);
            Console.WriteLine("a"+a);
            ;
        }
    }
}
