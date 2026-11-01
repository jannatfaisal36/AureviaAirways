using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AureviaAirways.Repository
{
    internal class autherizedRepo
    {
       
            string filePath = "updateflight.txt";
            string bookingPath = "bookings.txt";

           
            public void SaveBooking(string data)
            {
                File.AppendAllText(filePath, data + Environment.NewLine);

                Console.WriteLine("Update successful!");
            }

            
            public void ViewBookings(int customerID)
            {
                if (File.Exists(bookingPath))
                {
                    List<string> bookings =
                        new List<string>(File.ReadAllLines(bookingPath));

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

                    if (!found)
                    {
                        Console.WriteLine("No bookings found!");
                    }
                }
                else
                {
                    Console.WriteLine("No bookings found!");
                }
            }

       
            public void deleteBooking(int customerID, int bookingID)
            {
                if (File.Exists(bookingPath))
                {
                    List<string> bookings =
                        new List<string>(File.ReadAllLines(bookingPath));

                    for (int i = 0; i < bookings.Count; i++)
                    {
                        string[] details = bookings[i].Split('|');

                        if (details.Length >= 2 &&
                            details[0] == bookingID.ToString() &&
                            details[1] == customerID.ToString())
                        {
                            bookings.RemoveAt(i);

                            File.WriteAllLines(bookingPath, bookings);

                            Console.WriteLine("Booking Deleted!");
                            return;
                        }
                    }

                    Console.WriteLine("Booking not found!");
                }
                else
                {
                    Console.WriteLine("No bookings found!");
                }
            }

            public void ViewRevenue()
            {
                double totalRevenue = 0;

                if (File.Exists(bookingPath))
                {
                    string[] bookings = File.ReadAllLines(bookingPath);

                    foreach (string booking in bookings)
                    {
                        string[] details = booking.Split('|');

                        if (details.Length >= 5)
                        {
                            double price;

                            if (double.TryParse(details[4], out price))
                            {
                                totalRevenue += price;
                            }
                        }
                    }

                    Console.WriteLine("\n========== REVENUE REPORT ==========");
                    Console.WriteLine("Total Airline Revenue: PKR " + totalRevenue);
                    Console.WriteLine("====================================");
                }
                else
                {
                    Console.WriteLine("No bookings found.");
                }
            
            }
    }
}
