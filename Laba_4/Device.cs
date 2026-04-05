using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4
{
    internal class Device
    {
            private readonly int code; 
            private string model;       
            private double price;      

            protected static int count = 0; 

            public Device(int code, string model, double price)
            {
                this.code = code;
                this.model = model;
                this.price = price;
                count++;
            }

            public virtual void GetInfo()
            {
                Console.WriteLine($"Код: {code}, Модель: {model}, Ціна: {price} грн");
            }

            public bool IsExpensive()
            {
                return price > 45000;
            }

            protected int Code => code;
            protected string Model => model;
            protected double Price => price;

            public static int GetCount()
            {
                return count;
            }
            class Laptop : Device
            {
                private double screenDiagonal;

                public Laptop(int code, string model, double price, double screenDiagonal) : base(code, model, price)
                {
                    this.screenDiagonal = screenDiagonal;
                }

                public override void GetInfo()
                {
                    Console.WriteLine($"[Ноутбук] Код: {Code}, Модель: {Model}, Ціна: {Price} грн, Діагональ: {screenDiagonal} дюймів");
                }
            }
            class Tablet : Device
            {
                private bool simSupport;

                public Tablet(int code, string model, double price, bool simSupport) : base(code, model, price)
                {
                    this.simSupport = simSupport;
                }

                public override void GetInfo()
                {
                    string simText = simSupport ? "Так" : "Ні";
                    Console.WriteLine($"[Планшет] Код: {Code}, Модель: {Model}, Ціна: {Price} грн, Підтримка SIM: {simText}");
                }
            }
    }
}
