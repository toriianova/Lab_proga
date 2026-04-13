using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
        public abstract class Booking : ICancellable
        {
            public int Id { get; set; }
            public double BaseCost { get; set; }
            public int Duration { get; set; }

            public Booking(int id, double baseCost, int duration)//номер, ціна, тривалість
            {
                Id = id;//записуємо змінні в об'єкт
                BaseCost = baseCost;
                Duration = duration;
            }

            public abstract double CalculateTotalCost();

            public virtual string GetInfo()
            {
                return $"ID: {Id}, BaseCost: {BaseCost}, Duration: {Duration}";
            }

            public virtual void Cancel()//метод скасовує бронювання
            {
                Console.WriteLine($"Booking {Id} cancelled.");
            }
        }
}
