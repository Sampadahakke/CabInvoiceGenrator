using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    internal class InvoiceGenerator
    {
        private double COST_PER_KM = 10;
        private int COST_PER_MIN = 1;
        private int MINIMUM_FARE = 5;

        public double CalculateFare(double distance, int time)
        {
            double totalfare = 0;
            try
            {
                totalfare = distance * COST_PER_KM + time * COST_PER_MIN;
            }
            catch (CabInvoiceException)
            {
                if (time <= 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_TIME, "Invalid Time");
                }
                if (distance <= 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_DISTANCE, "Invalid Distance");
                }
            }
            return Math.Max(MINIMUM_FARE, totalfare);
        }
    }
}


