using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            // initial greeting
            Console.WriteLine("Hello, welcome to the fortune teller program.");
            Console.WriteLine("To find out your future, I will ask you a series of questions.");
            FortuneTelling();
        }

        public static void FortuneTelling()
        {
            // user input
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            string userInput = firstName;
            Quit(userInput);
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            userInput = lastName;
            Quit(userInput);
            Console.WriteLine(Greeting(firstName, lastName));
            Console.WriteLine("How old are you?");
            userInput = Console.ReadLine();
            Quit(userInput);
            int age = int.Parse(userInput);
            Console.WriteLine("In what month were you born? Please enter a numerical value only.");
            userInput = Console.ReadLine();
            Quit(userInput);
            int birthMonth = int.Parse(userInput);
            Console.WriteLine("Please type your favorite color from ROYGBIV or type \"help\" for more options.");
            string favoriteColor = Console.ReadLine().ToLower();
            userInput = favoriteColor;
            Quit(userInput);
            if (favoriteColor.ToLower().Contains("help"))
            {
                Console.WriteLine("ROYGBIV stands for red, orange, yellow, green, blue, indigo, violet.");
                Console.WriteLine("What is your favorite color from these choices?");
                favoriteColor = Console.ReadLine().ToLower();
                userInput = favoriteColor;
                Quit(userInput);
            }
            favoriteColor = favoriteColor.ToLower();
            Console.WriteLine("How many siblings do you have? Please enter a numerical value only.");
            userInput = Console.ReadLine();
            Quit(userInput);
            int siblingNumber = int.Parse(userInput);

            // fortune output
            Console.WriteLine(firstName + " " + lastName + " will retire in " + RetirementYears(age) + " years with $" + RetirementMoney(birthMonth) + " in the bank, a vacation home in " + VacationHome(siblingNumber) + " and a " + Transportation(favoriteColor) + ".");
            FortuneQuality();
        }

        // greeting message
        public static string Greeting (string firstName, string LastName)
        {
            return "Greetings, " + firstName + " " + LastName + ". I will tell you your fortune!";
        }

        // retirement age

        public static int RetirementYears(int age)
        {
            int ageDeterminant = (age % 2); // finding out if age is even or odd
            int yearsToRetirement = 0;

            if (ageDeterminant == 0)
            {
                yearsToRetirement = 35;
            }
            else if ((ageDeterminant > 0) || (ageDeterminant < 0))
            {
                yearsToRetirement = 25;
            }

            return yearsToRetirement;
        }

        // vacation home

        public static string VacationHome (int siblingNumber)
        {
            string vacationHomeDestination = ""; // Middle Earth locations

            if (siblingNumber > 3) // messy messy
            {
                vacationHomeDestination = ("Fangorn Forest");
            }
            else if (siblingNumber == 3)
            {
                vacationHomeDestination = ("Helms Deep");
            }
            else if (siblingNumber == 2)
            {
                vacationHomeDestination = ("Gondor");
            }
            else if (siblingNumber == 1)
            {
                vacationHomeDestination = ("Rivendell");
            }
            else if (siblingNumber == 0)
            {
                vacationHomeDestination = ("Isengard");
            }
            else if (siblingNumber < 0)
            {
                vacationHomeDestination = ("Mordor");
            }
            return vacationHomeDestination;
        }

        // mode of transportation

        public static string Transportation(string favoriteColor)
        {
            string modeOfTransportation = "";
            // 7 choices: horse, nazgul, eagle, oliphaunts, warg, shadowfax, boat

            switch (favoriteColor)
            {
                case "red":
                    modeOfTransportation = "horse";
                    break;
                case "orange":
                    modeOfTransportation = "nazgul";
                    break;
                case "yellow":
                    modeOfTransportation = "eagle";
                    break;
                case "green":
                    modeOfTransportation = "oliphaunt";
                    break;
                case "blue":
                    modeOfTransportation = "warg";
                    break;
                case "indigo":
                    modeOfTransportation = "Shadowfax";
                    break;
                case "violet":
                    modeOfTransportation = "boat";
                    break;
                default:
                    modeOfTransportation = "squeaky shopping cart";
                    break;
            }
            return modeOfTransportation;
        }

        // retirement money
        public static double RetirementMoney (int birthMonth)
        {
            // 1 - 4, 5 - 8, 9 - 12, 0 or less than 0 
            double retirementMoney = 0;

            if ((birthMonth < 1) || (birthMonth > 12))
            {
                retirementMoney = 0;
            }
            else if ((birthMonth >= 1) && (birthMonth <= 4))
            {
                retirementMoney = 30000;
            }
            else if ((birthMonth >= 5) && (birthMonth <= 8))
            {
                retirementMoney = 40000;
            }
            else if ((birthMonth >= 9) && (birthMonth <= 12))
            {
                retirementMoney = 50000;
            }

            return retirementMoney;
        }

        public static void FortuneQuality ()
        {

            Console.WriteLine("I'm in Middle Earth?");
        }

        public static void Quit(string userInput)
        {
            if (userInput.ToLower() == "quit")
            {
                Console.Clear();
                Environment.Exit(0);
            }

            else if (userInput.ToLower() == "restart")
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                FortuneTelling();
            }

            else
            {
                // nothing here :(
            }
        }


    }
}
