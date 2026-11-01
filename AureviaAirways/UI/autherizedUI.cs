using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AureviaAirways.servive_layer;
namespace AureviaAirways.UI
{
    internal class autherizedUI
    {
        autherizedSE service = new autherizedSE();
        
        public void autherizedmenu()
        {
            Console.Clear();
            Console.WriteLine("1.Flight Managment");
            Console.WriteLine("2.Passanger records");
            Console.WriteLine("3.Booking Managment");
            Console.WriteLine("4.Revenue");
            Console.WriteLine("5.Exit");
            Console.WriteLine();
            Console.Write("Select an option to proceed:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("---------Flight Management----------");
                    service.ViewFlights();
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("--------- Passenger Records ---------");

                    Console.Write("Enter Customer ID: ");
                    int cID = Convert.ToInt32(Console.ReadLine());

                    service.ViewAllBookings(cID);

                    Console.ReadKey();
                    autherizedmenu();
                    break;
                case "3":
                    Console.WriteLine("---------Booking Management------------");
                    Console.Write("Enter Customer ID: ");
                    int customerID = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Booking ID: ");
                    int bookingID = Convert.ToInt32(Console.ReadLine());
                    service.DeleteFlight(customerID, bookingID);

                    Console.ReadKey();
                    break;

                case "4":
                    Console.WriteLine("----------Revenue & Reports------------");
                    service.ViewRevenue();
                    Console.ReadKey();
                    break;

                case "5":
                    Console.WriteLine("Returning to main menu...");

                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.ReadKey();
                    break;
            }
           
        }
    }
}
