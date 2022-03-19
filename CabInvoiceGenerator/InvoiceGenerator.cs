using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    internal class InvoiceGenerator
    {
        //Initializing variables 
        private readonly double COST_PER_KM;
        private readonly int COST_PER_MIN;
        private readonly int MINIMUM_FARE;

        //Creating constructor to initialize declared variables
        public InvoiceGenerator(RideType type)
        {
            if (type.Equals(RideType.NORMAL))
            {
                COST_PER_KM = 10;
                COST_PER_MIN = 1;
                MINIMUM_FARE = 5;
            }
        }

        //Creating method to calculate fare
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

        //Calculating fare for multiple rides
        public double MultipleRides(RideData[] rides)
        {
             double totalfare=0;
            if (rides.Length == 0)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDES, "No rides found");
            }
            else
            {
                foreach(var ride in rides)
                {
                   
                    totalfare+=CalculateFare(ride.distance, ride.time);
                }
                
            }
            double aggregateFare=Math.Max(MINIMUM_FARE, totalfare);
            return aggregateFare;
        }
    }
}


