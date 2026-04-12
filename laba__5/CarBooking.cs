using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
        public class CarBooking : Booking
        {
            public double InsuranceFee { get; set; }

            public CarBooking(int id, double baseCost, int days, double insuranceFee)
                : base(id, baseCost, days)
            {
                InsuranceFee = insuranceFee;
            }

            public override double CalculateTotalCost()
            {
                return BaseCost * Duration + InsuranceFee;
            }

            public override string GetInfo()
            {
                return base.GetInfo() + $", Insurance: {InsuranceFee}";
            }
        }
}
