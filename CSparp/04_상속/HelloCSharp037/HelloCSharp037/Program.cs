using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.name = "뭉치";
            a.age = 10;
            Animal b = new Animal();
            b.name = "루이";
            b.age = 0;
            //Run, Fight는 Program 내에서는 호출 불가능
            a.Sleep();
            a.LivingWorld();
            b.Sleep();
            b.LivingWorld();
            Cat c = new Cat();
            c.name = "네로";
            c.age = 5;
            c.Meow();
            c.Sleep();
            c.LivingWorld();
            Dog d = new Dog();
            d.name = "멍뭉이";
            d.age = 0;
            d.LivingWorld();
            d.Sleep();
            d.Bark();

            //상속에 의해서 그리고 다형성에 의해서 Animal타입의 리스트에
            //Animal, Cat, Dog가 모두 포함될 수 있다.
            List<Animal> zoo = new List<Animal>();
            zoo.Add(a);
            zoo.Add(b);
            zoo.Add(c);
            zoo.Add(d);

            //다형성:다양한 형태로 변형 가능성
            //A is B
            //A=전화기 B=휴대폰(불가능)
            // A=스마트폰 B=전화기(가능)
            // CAt is Animal.(O)
            // Animal is Cat.(X)
            // B temp =new A();
            //조상클래스 temp = new 자손클래스();

            Animal aaa = new Cat();
            Animal bbb = new Dog();
            Object o = new Animal();
            object oo = new Animal(); // Object=object

            //aaa.meow
            ((Cat)(aaa)).Meow();
            // ((Cat)(bbb)).Meow(); //에러코드임
            if (aaa is Cat)
            {
                ((Cat)(aaa)).Meow(); ; //강제 형변환
                (aaa as Cat).Meow();   //강제 형변환
            }
            var tempCat = aaa as Cat;
            if ((tempCat != null))
            {
                tempCat.Meow();
                var tempAnimal = bbb as Cat;
                if ((tempAnimal == null))
                    Console.WriteLine("이거 고양이 아님");

                foreach (var item in zoo)
                {
                    item.Sleep();
                    item.LivingWorld();
                    if (item is Cat)
                    {
                        (item as Cat).Meow();

                    }
                    if (item is Dog)
                    {
                        (item as Dog).Bark();
                    }
                }


            }
            Animal a1 = new Animal();
            a1.name = "짹짹이";
            Cat c1 = new Cat();
            c1.name = "냥냥이";
            Dog d1 = new Dog();
            d1.name = "멍멍이";
            Animal.zooName = "경북동물원";
            Console.WriteLine(Animal.zooName);
            Console.WriteLine(d1.name);
            Console.WriteLine(c1.name);
            Console.WriteLine(a1.name);
            Console.WriteLine("---------------------");
            Animal ani1 = new Animal();
            Cat cat1 = new Cat();
            Dog dog1 = new Dog();
            Animal cat2 = new Cat();
            Animal dog2 = new Dog();
            Console.WriteLine();

            List<Animal> animals = new List<Animal>();
            animals.Add(ani1);
            animals.Add(dog1);  
            animals.Add(dog2);
            animals.Add(cat1);
            animals.Add(cat2);
            foreach (Animal animal in animals) 
            {
                Console.WriteLine("@@@@@@@@@@");
                animal.Eat();
                animal.Charm();
                animal.Cry();

            }

            Console.WriteLine("음식");

            //Food f = new Food(); <-안됨 
            //상속 받은 클래스로 클래스를 만들 수 없음
            //Food만으로는 인스턴스 못 만듦
            //추상화 = 구체화를 못한다 = 인스턴스 못 만든다
            Food f1 = new Gimbab();
            Food f2 = new Nahn();
            Gimbab g1 = new Gimbab();
            Nahn n1 = new Nahn();

            f1.taste(); 
            f2.taste();
            g1.taste();
            n1.taste();




        }
     


    }
}