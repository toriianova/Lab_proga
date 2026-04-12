using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
        public class HotelBooking : Booking
        {
            public int Nights { get; set; }

            public HotelBooking(int id, double baseCost, int nights)
                : base(id, baseCost, nights)
            {
                Nights = nights;
            }

            public override double CalculateTotalCost()
            {
                return BaseCost * Nights;
            }

            public override string GetInfo()
            {
                return base.GetInfo() + $", Nights: {Nights}";
            }
        }
}
