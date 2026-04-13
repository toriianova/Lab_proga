using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
        public class RoomBooking : Booking
        {
            public double ServiceCoefficient { get; set; }//коефіцієнт сервісу

            public RoomBooking(int id, double baseCost, int hours, double coefficient)
                : base(id, baseCost, hours)
            {
                ServiceCoefficient = coefficient;
            }

            public override double CalculateTotalCost()
            {
                return BaseCost * Duration * ServiceCoefficient;
            }

            public override string GetInfo()
            {
                return base.GetInfo() + $", Coefficient: {ServiceCoefficient}";
            }
        }
}
