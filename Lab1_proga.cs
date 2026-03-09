using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nНомер завдання");
            Console.WriteLine("1 - Завдання 1 ");
            Console.WriteLine("2 - Завдання 2 ");
            Console.WriteLine("3 - Завдання 3 ");
            Console.WriteLine("0 - Вийти");
            Console.Write("Вибiр завдання: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Task1();
                    break;
                case "2":
                    Task2();
                    break;
                case "3":
                    Task3();
                    break;
                case "0":
                    Console.WriteLine("Вихiд з програми...");
                    return;
                default:
                    Console.WriteLine("Помилка!");
                    break;
            }
        }
    }
    //У списку всі елементи різні. Поміняйте місцями мінімальний і максимальний елемент цього списку.
    static void Task1()
    {
        List<int> numbers = new List<int> { -15, 2, -9, 1, 7, 0 };

        Console.WriteLine("Початковий список:");
        foreach (int n in numbers)
        {
            Console.Write(n + " ");
        }

        int min = numbers.Min(); //метод LINQ виводить мін і мах елементи
        int max = numbers.Max();

        int minIndex = numbers.IndexOf(min);// Знаходимо їхні індекси
        int maxIndex = numbers.IndexOf(max);

        int temp = numbers[minIndex];//записуємо мінімальне
        numbers[minIndex] = numbers[maxIndex];//міняємо з максимальним
        numbers[maxIndex] = temp;
        Console.WriteLine("\nПiсля замiни:");
        foreach (int n in numbers)
        {
            Console.Write(n + " ");
        }
    }
    //Відсортувати значення ключів словника по спаданню. Вхідний словник : {'Math':81, 'Physics':83, 'Chemistry':87}. Очікуваний результат: [('Chemistry', 87), ('Physics', 83), ('Math', 81)]
    static void Task2()
    {
        Dictionary<string, int> subjects = new Dictionary<string, int>
        {
            { "Math", 81 },
            { "Physics", 83 },
            { "Chemistry", 87 }
        };

        var sortedResult = subjects.OrderByDescending(x => x.Value);//метод LINQ - сортує елементи від більшого до меншого

        var formattedOutput = sortedResult.Select(x => $"('{x.Key}', {x.Value})");//записує як ключ-знач
        Console.WriteLine("[" + string.Join(", ", formattedOutput) + "]");
    }
    //Дана послідовність додатних цілих чисел. Обробляючи тільки непарні числа, отримати послідовність їх строкових уявлень і впорядкувати її в лексикографічному порядку по зростанню.
    static void Task3()
    {
        int[] numbers = { 10, 3, 5, 8, 11, 14, 7 };

        var result = numbers
            .Where(n => n % 2 != 0)//берем непарні
            .Select(n => n.ToString())//перетворюєм в рядок
            .OrderBy(str => str); //сортування за зростанням

        Console.WriteLine("\nРезультат:");
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}