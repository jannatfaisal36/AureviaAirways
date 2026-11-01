using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AureviaAirways.UI
{
    internal class AureviaUI
    {
        public void mainmenu()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("                  AUREVIA                     ");
            Console.WriteLine("       Beyond Travel. Above Expectations.     ");
            Console.WriteLine("==============================================");
            Console.WriteLine();
            Console.WriteLine("1.Begin Your Journey");
            Console.WriteLine("2.Authorized Access");
            Console.WriteLine("3.EXIT");
            Console.WriteLine();
            Console.Write("Select an option to proceed:");

            string choice=Console.ReadLine();
            if(choice == "1")
            {
                Console.WriteLine("      YOUR JOURNEY BEGINS HERE            ");
                customerUI customer = new customerUI();
                customer.customermenu();
            }
            if (choice == "2")
            {
                Console.WriteLine("          AUTHORIZED ACCESS                   ");
                autherizedUI autherized = new autherizedUI();
                autherized.autherizedmenu();
            }
            if (choice == "3")
            {
                Console.WriteLine("Thanks for choosing aurevia!");
            }
            
        }
    }
}
