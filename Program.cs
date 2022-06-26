using System;

namespace LAB7
{
    class Animal
    {
        public string name;
        public int age;

        public virtual void AnimalSound()
        {
            Console.WriteLine("Animal makes sound"); 
        }
    }

    class Dog : Animal
    {
        public Dog(string Name, int Age)
        {
           name = Name;
           age = Age;
        }

        public override void AnimalSound()
        {
            Console.WriteLine("Name = {0}  Age = {1}", name, age);
            Console.WriteLine("woof! woof!!");
        }
    }

    class Frog : Animal
    {
        public Frog(string Name, int Age)
        {
            name = Name;
            age = Age;
        }

        public override void AnimalSound()
        {
            Console.WriteLine("Name = {0}  Age = {1}", name, age);
            Console.WriteLine("burp! burp!!");
        }
    }

    class Cat : Animal
    {
        public Cat(string Name, int Age)
        {
            name = Name;
            age = Age;
        }

         public override void AnimalSound()
        {
            Console.WriteLine("Name = {0}  Age = {1}", name, age);
            Console.WriteLine("meow! meow!!");
        }
    }

    class Kitten : Animal
    {
         public Kitten(string Name, int Age)
        {
            name = Name;
            age = Age;
        }

         public override void AnimalSound()
        {
            Console.WriteLine("Name = {0}  Age = {1}", name, age);
            Console.WriteLine("meow! meow!!");
        }
    }

    class Tomcat : Animal
    {
          public Tomcat(string Name, int Age)
        {
            name = Name;
            age = Age;
        }

         public override void AnimalSound()
        {
            Console.WriteLine("Name = {0}  Age = {1}", name, age);
            Console.WriteLine("meow! meow!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] anim = new Animal[5];
            anim[0] = new Dog("Bingo", 3);
            anim[1] = new Frog("Woody", 6);
            anim[2] = new Cat("Skittles", 1);
            anim[3] = new Kitten("Morpheous", 5);
            anim[4] = new Tomcat("Tom", 2);

            foreach(Animal a in anim)
            {
                a.AnimalSound();
            }
        }
    }
}
