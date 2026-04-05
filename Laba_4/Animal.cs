using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4
{
    internal class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
            Console.WriteLine("Викликано конструктор Animal");
        }

        public void ShowName()
        {
            Console.WriteLine($"Ім'я тварини: {Name}");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Тварина видає звук");
        }

        public virtual void Run()
        {
            Console.WriteLine("Тварина біжить");
        }
        public override string ToString()
        {
            return $"Animal: {Name}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Animal other)
                return Name == other.Name;

            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            Console.WriteLine("Викликано конструктор Dog");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} гавкає");
        }

        public void Bite()
        {
            Console.WriteLine($"{Name} кусає");
        }
        public override string ToString()
        {
            return $"Dog: {Name}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Dog other)
                return Name == other.Name;

            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
    class Puppy : Dog
    {
        public Puppy(string name) : base(name)
        {
            Console.WriteLine("Викликано конструктор Puppy");
        }

        public void Jump()
        {
            Console.WriteLine($"{Name} стрибає");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} пищить");
        }

        public override void Run()
        {
            Console.WriteLine($"{Name} біжить");
        }
        public override string ToString()
        {
            return $"Puppy: {Name}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Puppy other)
                return Name == other.Name;

            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
