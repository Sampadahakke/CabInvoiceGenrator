using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    internal class RideRepository
    {
        //Declaring Dictinary
        Dictionary<string, List<RideData>> userRides;
        //Creating constructor to initialize dictonary
        public RideRepository()
        {
            userRides = new Dictionary<string, List<RideData>>();
        }

        //Creating method to add rides
        public void AddRide(string userId, RideData[] rideDatas)
        {
            if (userRides.ContainsKey(userId))
            {
                Console.WriteLine("User already exist..");
            }
            else
            {
                List<RideData>list=new List<RideData>();
                list.AddRange(rideDatas);
                userRides.Add(userId, list);
            }
        }

        //Creating method to get rides of any user
        public RideData[] getRides(string userId)
        {
            try
            {
                return userRides[userId].ToArray();
            }
            catch (Exception)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_USER_ID, "Invalid user ID");
            }
        }

       
    }
}
