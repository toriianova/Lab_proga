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
    }
    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            Console.WriteLine("Викликано конструктор Dog");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Собака гавкає");
        }

        public void Bite()
        {
            Console.WriteLine("Собака кусає");
        }
    }
}
