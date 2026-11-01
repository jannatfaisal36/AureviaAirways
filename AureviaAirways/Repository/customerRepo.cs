using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AureviaAirways.Repository
{
    internal class customerRepo
    {
        string filePath = "bookings.txt";
        
        public void SaveBooking(string data)
        {
            File.AppendAllText(filePath, data + Environment.NewLine);

            Console.WriteLine("Booking saved!");
        }
        public void ViewBookings(int customerID)
        {
            if (File.Exists(filePath))
            {
                List<string> bookings =
                    new List<string>(File.ReadAllLines(filePath));

                bool found = false;

                foreach (string booking in bookings)
                {
                    string[] details = booking.Split('|');

                    if (details.Length == 5 &&
                        details[1] == customerID.ToString())
                    {
                        Console.WriteLine("\n----- BOOKING DETAILS -----");

                        Console.WriteLine("Booking ID: " + details[0]);
                        Console.WriteLine("Customer ID: " + details[1]);
                        Console.WriteLine("Flight ID: " + details[2]);
                        Console.WriteLine("Destination: " + details[3]);
                        Console.WriteLine("Ticket Price: PKR " + details[4]);

                        Console.WriteLine("---------------------------");

                        found = true;
                    }
                }

                if (found == false)
                {
                    Console.WriteLine("No bookings found!");
                }
            }
            else
            {
                Console.WriteLine("No bookings found!");
            }
        }
        public void CancelBooking(int customerID, int bookingID)
        {
            if (File.Exists(filePath))
            {
                List<string> bookings =
                    new List<string>(File.ReadAllLines(filePath));

                for (int i = 0; i < bookings.Count; i++)
                {
                    string[] details = bookings[i].Split('|');

                    if (details[0] == bookingID.ToString() &&
                        details[1] == customerID.ToString())
                    {
                        bookings.RemoveAt(i);

                        File.WriteAllLines(filePath, bookings);

                        Console.WriteLine("Booking cancelled!");
                        return;
                    }
                }

                Console.WriteLine("Booking not found!");
            }
        }
    }
}
