using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesandOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing new firstName variable
            string firstName = "Jerome";
            //Printing the value of firstName to the console
            Console.WriteLine(firstName);
            //intializing new birthMonth variable
            string birthMonth = "January";
            //Printing the value of birthMonth to the console
            Console.WriteLine(birthMonth);
            int age = 65;
            string why = "because I said so";
            char firstInitial = 'J';
            //floating point types
            float floatNumber = 2.164403304897294849383961032f;
            Console.WriteLine(floatNumber);
            double doubleNumber = 2.164403304897294849383961032d;
            Console.WriteLine(doubleNumber);
            decimal decimalNumber = 2.164403304897294849383961032m;
            Console.WriteLine(decimalNumber);
            int jessicaAge = 23;
            int samAge = 47;
            Console.WriteLine(jessicaAge < samAge);
            Console.WriteLine("What is the name on the reservation");
            string reserveName = Console.ReadLine();
            Console.WriteLine("How many people are in your party");
            int numberOfPeople = int.Parse(Console.ReadLine());
            double amountEach = 13.53d;
            double totalBill = numberOfPeople * amountEach;
            Console.WriteLine("Reservation: " + reserveName);
            Console.WriteLine("Total Due: $" + totalBill);

            double cupsNeeded = 7;
            Console.WriteLine("How many cups added");
            double cupsAdded = double.Parse(Console.ReadLine());
            double cupsLeft = cupsNeeded - cupsAdded;
            Console.WriteLine("Add " + cupsLeft + " cups");

            string donorName = "";
            string donorAddress = "";
            string donorEmail = "";
            string fiscalYear = "";

            Console.WriteLine("Donors Name");
            donorName = Console.ReadLine();

            Console.WriteLine("Donors Address");
            donorAddress = Console.ReadLine();

            Console.WriteLine("Donor Email");
            donorEmail = Console.ReadLine();

            Console.WriteLine("Fiscal Year");
            fiscalYear = Console.ReadLine();

            Console.WriteLine("How many quarters?");
            double quarters = double.Parse(Console.ReadLine()) * .25;

            Console.WriteLine("How many ones");
            int ones = int.Parse(Console.ReadLine()) * 1;

            Console.WriteLine("How many fives?");
            int fives = int.Parse(Console.ReadLine()) * 5;



        }
    }
}
