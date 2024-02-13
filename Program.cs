////////////////////////////////////////////////////
// Evelyn Jimenez
// T INFO C C# Programming
// SkyTour Project
// 01-19-2023
////////////////////////////////////////////////////
// Change history
// Date             Developer           Description
// 2023-01-18       jimene4             Initial file src code for SkyTour program
// 2023-01-18       jimene4             Completed user interface and output statement, testing, delivery
// 2023-01-19       jimene4             Modified lbs to kilo conversion
////////////////////////////////////////////////////
// The ticket calculator is designed to convert the passengers weight
// in US pounds to kilograms, write out a report of data entered and 
// calculated to the output console, including a timestamp of the transaction.
// The user will be asked for their name, age, and weight in US pounds
////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

// This app is designed to calculate the passengers weight in kilos
// in order to determine determine the price of the ticket. The app will
// then print out a ticket for the customer
namespace SkyTour
{
    // Currently this app is a 1 class project
    // Program.cs is the sole class in the system - main is here
    internal class Program
    {
        // Main entry point of the program
        static void Main(string[] args)
        {
            Console.WriteLine("**** SkyTour Ticket Calculator ****");
            Console.WriteLine(@"
************************************************************
This app is designed to convert weight in US pounds to kilograms,
and print out a report with your information and price
of the ticket. You will be asked for your name, age and weight 
in US pounds.
Thank you for touring with SkyTour, Inc!
************************************************************
");
            // Input section
            Console.Write("Please ENTER your first name: ");
            string first = Console.ReadLine();
            Console.Write("Please ENTER your last name: ");
            string last = Console.ReadLine();
            Console.Write("Please ENTER your age [ex: 21]: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Now we need your weight to calculate the price for your ticket.");
            Console.Write("ENTER your weight in US pounds [ex: 220.5]: ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine();



            // Processing section

            DateTime thisDay = DateTime.Now;

            double kiloWeight = weight / 2.205;

            kiloWeight = Math.Round(kiloWeight);

            if (kiloWeight <= 100)
            {
                double weight1 = 1.00 * kiloWeight;

                Console.WriteLine($"Passenger Name: {first} {last}");
                Console.WriteLine($"Passenger Age: {age} years");
                Console.WriteLine($"Weight: {weight} lbs. ({kiloWeight:00.00} Kg) price ${weight1:00.00}");
                Console.WriteLine($"Report Timestamp: {thisDay}");
            }
            if (kiloWeight > 100)
            {
                double diff = kiloWeight - 100;
                double weight3 = diff * 1.5;
                double weight4 = 100 + weight3;

                Console.WriteLine($"Passenger Name: {first} {last}");
                Console.WriteLine($"Passenger Age: {age} years");
                Console.WriteLine($"Weight: {weight} lbs. ({kiloWeight:00.00} Kg) price ${weight4:00.00}");
                Console.WriteLine($"Report Timestamp: {thisDay}");
            }
        }
    }
}
