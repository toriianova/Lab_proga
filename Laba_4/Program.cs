using System;
using System.Text;

namespace Laba_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Puppy puppy = new Puppy("Трой");

            puppy.ShowName();
            puppy.MakeSound();
            puppy.Jump();
            puppy.Run();
            puppy.Bite();

            Console.WriteLine(puppy.ToString());
        }
    }
}