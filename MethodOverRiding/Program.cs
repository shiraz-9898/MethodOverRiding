using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverRiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Cat c = new Cat();
            Dog d = new Dog();

            a.AnimalSound();
            c.AnimalSound();
            d.AnimalSound();

            Console.ReadKey();
        }
    }

    public class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The Sound of the Animal");
        }
    }

    public class Cat : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Cat says Meooow");
        }
    }

    public class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Dog says bhaaoo");
        }
    }
}
