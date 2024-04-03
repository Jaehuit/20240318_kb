using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal a = new Animal();
            Animal c = new Cat();
            Animal d = new Dog();
            Animal b = new Bulbasaur();

            Cat c1 = new Cat();
            Dog d1 = new Dog();
            Bulbasaur b1 = new Bulbasaur();

            IPlant p = new Bulbasaur();
            IPokemon p2 = new Bulbasaur();

            b1.ability = "심록";
            b1.name = "겸둥이";
            b1.age = 5;
            b1.description = "고집있는 성격";
            Console.WriteLine(b1.age); //5
            b1.age = -5;
            Console.WriteLine(b1.age); //0
            b1.sleep();
            b1.eat();
            b1.cry();
            b1.photosynthesis();
            b1.bearFruit();
            b1.blooming();
            b1.charming();
            b1.fight();

            Bulbasaur i1 = new Ivysaur();
            IPokemon i2 = new Ivysaur();
            IPlant i3 = new Ivysaur();
            Ivysaur i = new Ivysaur();

            i.cry();
            i.fight();


        }
    }
}