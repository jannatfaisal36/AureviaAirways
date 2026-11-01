using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AureviaAirways.servive_layer;
namespace AureviaAirways.UI
{
    internal class customerUI
    {
        customerSE service = new customerSE();
        public void customermenu()
        {
            string choice = "";
            while (choice != "5")
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("            AUREVIA AIRWAYS");
                Console.WriteLine("          YOUR JOURNEY BEGINS HERE");
                Console.WriteLine("========================================");
                Console.WriteLine();
                Console.WriteLine("1. Search Flights");
                Console.WriteLine("2. Book a Flight");
                Console.WriteLine("3. View My Bookings");
                Console.WriteLine("4. Cancel a Booking");
                Console.WriteLine("5. Return to Main Menu");
                Console.WriteLine();
                Console.Write("Select an option to proceed: ");

                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("--------Search Flights--------");
                        service.SearchFlights();
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("---------Book a Flight------------");
                        Console.Write("Enter Booking ID: ");
                        string bookingID = Console.ReadLine();

                        Console.Write("Enter Customer ID: ");
                        string customerID = Console.ReadLine();

                        Console.Write("Enter Flight ID: ");
                        string flightID = Console.ReadLine();

                        Console.Write("Enter Destination: ");
                        string destination = Console.ReadLine();

                        Console.Write("Enter Ticket Price: ");
                        string price = Console.ReadLine();

                        string data = bookingID + "|" + customerID + "|" +
                                      flightID + "|" + destination + "|" + price;

                        service.BookFlight(data);
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("---------View My Bookings--------");

                        Console.Write("Enter Customer ID: ");
                        int customer = Convert.ToInt32(Console.ReadLine());

                        service.ViewBookings(customer);
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("--------Cancel a Booking----------");
                        Console.Write("Enter Customer ID: ");
                        int cID = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Booking ID: ");
                        int bID = Convert.ToInt32(Console.ReadLine());

                        service.CancelBooking(cID, bID);

                        Console.ReadKey();
                        break;

                    case "5":
                        Console.WriteLine("Returning to Main Menu...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        Console.ReadKey();
                        break;
                }
            }
     
    

        }
    }
}
