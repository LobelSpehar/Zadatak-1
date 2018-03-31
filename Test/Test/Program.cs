using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            string userInput;
            string firstName;
            string lastName;
            string GPA;
            int counter = 1;
            decimal number = 0;
            List<string> studentContainer = new List<string>();
            while (n < 1)
            {
                Console.WriteLine("Operation:");
                userInput = Console.ReadLine().ToUpper();
                if (userInput == "ENLIST")
                {
                    firstName = "";
                    lastName = "";
                    GPA = "";
                    while (firstName == "")
                    {
                        Console.WriteLine("Student\nFirst name:");
                        firstName = Console.ReadLine();
                        if (firstName == "")
                        {
                            Console.WriteLine("You need to insert value.");
                        }
                    }
                    while (lastName == "")
                    {
                        Console.WriteLine("Last name:");
                        lastName = Console.ReadLine();
                        if (lastName == "")
                        {
                            Console.WriteLine("You need to insert value.");
                        }
                    }
                    while (!decimal.TryParse(GPA, out number))
                    {
                        Console.WriteLine("GPA:");
                        GPA = Console.ReadLine();
                        if (!decimal.TryParse(GPA, out number))
                        {
                            Console.WriteLine("You need to insert numerical value.");
                        }
                    }
                    studentContainer.Add(counter + ". " + lastName + ", " + firstName + " - " + GPA);
                    counter++;
                }
                else if (userInput == "DISPLAY")
                {
                    Console.WriteLine("Students in a system:");
                    studentContainer.Sort();
                    studentContainer.ForEach(Console.WriteLine);
                    n = 1;
                    Console.WriteLine("Press enter to close...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\nOperation non-existing, please use appropriate operation");
                }
            }
        }
    }
}
