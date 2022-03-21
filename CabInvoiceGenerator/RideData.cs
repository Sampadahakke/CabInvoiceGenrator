using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    internal class RideData
    {
        public double distance;
        public int time;

        public RideData(double distance, int time)
        {
            this.distance = distance;
            this.time = time;       
        }

        public override string ToString()
        {
            return ($"distance:{distance} time:{time}");
        }
    }
}
