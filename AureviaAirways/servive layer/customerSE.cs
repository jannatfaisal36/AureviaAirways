using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AureviaAirways.UI;
using AureviaAirways.Repository;
using System.Security.Cryptography.X509Certificates;

namespace AureviaAirways.servive_layer
{
    internal class customerSE
    {

        customerRepo repo = new customerRepo();
        public void SearchFlights()
        {
            Console.WriteLine("\n========== AUREVIA AIRWAYS ==========");
            Console.WriteLine("          AVAILABLE FLIGHTS");
            Console.WriteLine("=====================================");

            Console.WriteLine("\nFlight ID: 101");
            Console.WriteLine("Destination: Dubai");
            Console.WriteLine("Departure: Lahore");
            Console.WriteLine("Date: 15 November 2026");
            Console.WriteLine("Time: 09:00 AM");
            Console.WriteLine("Ticket Price: PKR 45,000");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("\nFlight ID: 102");
            Console.WriteLine("Destination: London");
            Console.WriteLine("Departure: Lahore");
            Console.WriteLine("Date: 16 November 2026");
            Console.WriteLine("Time: 02:30 PM");
            Console.WriteLine("Ticket Price: PKR 150,000");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("\nFlight ID: 103");
            Console.WriteLine("Destination: Istanbul");
            Console.WriteLine("Departure: Islamabad");
            Console.WriteLine("Date: 17 November 2026");
            Console.WriteLine("Time: 11:00 AM");
            Console.WriteLine("Ticket Price: PKR 85,000");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("\nFlight ID: 104");
            Console.WriteLine("Destination: Karachi");
            Console.WriteLine("Departure: Lahore");
            Console.WriteLine("Date: 18 November 2026");
            Console.WriteLine("Time: 06:00 PM");
            Console.WriteLine("Ticket Price: PKR 18,000");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("\nFlight ID: 105");
            Console.WriteLine("Destination: Riyadh");
            Console.WriteLine("Departure: Lahore");
            Console.WriteLine("Date: 19 November 2026");
            Console.WriteLine("Time: 08:00 AM");
            Console.WriteLine("Ticket Price: PKR 65,000");
            Console.WriteLine("-------------------------------------");
        }
        public void BookFlight(string data)
        {
            repo.SaveBooking(data);
        }

        public void ViewBookings(int customerID)
        {
            repo.ViewBookings(customerID);
        }

        public void CancelBooking(int customerID, int bookingID)
        {
            repo.CancelBooking(customerID, bookingID);
          
        }
    }
}
