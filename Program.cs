using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;

        }
        public virtual string MakeSound()
        {
            return "Animal make sound";
        }
    }

    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }
        public override string MakeSound()
        {
            return "Dog barks";
        }
    }
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }
        public override string MakeSound()
        {
            return "Cat meows";
        }
    }

    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age) { }
        public override string MakeSound()
        {
            return "Bird chirps";
        }
    }
    class Program
    {
        static void Main()
        {
            Animal[] animals = {
                new Dog("Tuffy", 3),
                new Cat("Goldy", 2),
                new Bird("Piku", 1)
            };

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Name} ({animal.GetType().Name}) - {animal.MakeSound()}");
            }
        }
    }
}



