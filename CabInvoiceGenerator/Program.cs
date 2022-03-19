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
            //Creating method 
            InvoiceGenerator invoice = new InvoiceGenerator();
            double fare = invoice.CalculateFare(24,5);
            Console.WriteLine("Total fare = " + fare + " Rs ");
            Console.ReadKey();
        }
    }
}
