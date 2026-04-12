using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
        public class BookingSystem
        {
            private List<Booking> bookings = new List<Booking>();

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
                return bookings.OrderByDescending(b => b.CalculateTotalCost()).First();
            }

            // Середня вартість
            public double GetAverageCost()
            {
                return bookings.Average(b => b.CalculateTotalCost());
            }
        }
}
