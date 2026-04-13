using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
        public class BookingSystem//клас на систему бронювання
        {
            private List<Booking> bookings = new List<Booking>();//список зберігає різні типи бронювань

            // Додати бронювання
            public void AddBooking(Booking booking)
            {
                bookings.Add(booking);
            }

            // Вивести всі бронювання
            public void ShowAll()
            {
                foreach (var b in bookings)
                {
                    Console.WriteLine(b.GetInfo());
                    Console.WriteLine($"Total cost: {b.CalculateTotalCost()}");
                    Console.WriteLine("----------------------");
                }
            }

            // Найдорожче бронювання
            public Booking GetMostExpensive()
            {
                return bookings.OrderByDescending(b => b.CalculateTotalCost()).First();//сортуємо від більшого до меншого + беерм перше число (найдорожче)
            }

            // Середня вартість
            public double GetAverageCost()
            {
                return bookings.Average(b => b.CalculateTotalCost());
            }
        }
}
