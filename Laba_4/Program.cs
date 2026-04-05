using System;
using System.Text;
using System.Collections.Generic;

namespace Laba_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Вибір завдання:");
            Console.WriteLine("1 - Puppy / Animals");
            Console.WriteLine("2 - Магазин електроніки");
            Console.Write("Ваш вибір: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunPuppy();
                    break;

                case "2":
                    ElectronicsStore();
                    break;

                default:
                    Console.WriteLine("Невірний вибір!");
                    break;
            }
        }

        static void RunPuppy()
        { Puppy puppy = new Puppy("Трой");

            puppy.ShowName();
            puppy.MakeSound();
            puppy.Jump();
            puppy.Run();
            puppy.Bite();

            Console.WriteLine(puppy.ToString());
        }

        static void ElectronicsStore()
        {
            List<Device> devices = new List<Device>();

            // Створюємо девайси
            devices.Add(new Laptop(101, "Asus ROG", 50000, 15.6));
            devices.Add(new Laptop(102, "HP Pavilion", 40000, 14));
            devices.Add(new Tablet(261, "iPad Pro", 60000, true));
            devices.Add(new Tablet(292, "Samsung Tab", 30000, false));

            double totalPrice = 0;
            int expensiveCount = 0;

            // Виводимо інформацію та підраховуємо
            foreach (var device in devices)
            {
                device.GetInfo();
                totalPrice += device.Price;
                if (device.IsExpensive())
                    expensiveCount++;
            }

            Console.WriteLine($"\nЗагальна кількість девайсів: {Device.GetCount()}");
            Console.WriteLine($"Загальна сума цін: {totalPrice} грн");
            Console.WriteLine($"Кількість дорогих девайсів (>45000 грн): {expensiveCount}");
        }
    }
}
