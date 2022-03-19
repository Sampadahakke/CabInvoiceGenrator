using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================Welcome To Cab Invoice Generator==========================");
            //Creating object of class
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            Console.WriteLine("----------------------UC1-----------------");
            double fare = invoice.CalculateFare(0,5);
            Console.WriteLine("Total fare = " + fare + " Rs ");
            Console.WriteLine("-------------------UC2 AND UC3-----------------");
            RideData[] rides = { new RideData(10, 15), new RideData(10, 20) };
            double aggFare=invoice.MultipleRides(rides);
            Console.WriteLine("Aggregate fare = " + aggFare);
            Console.WriteLine("Total number of rides = " + rides.Length);
            double avgFare = aggFare / rides.Length;
            Console.WriteLine("Average fare = " + avgFare);
            Console.ReadKey();
        }
    }
}
