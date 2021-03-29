using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipInfo
{
    class HowManyHits
    {
        private object howManyHits;

        public object GetHowManyHits()
        {
            return howManyHits;
        }

        internal void SetHowManyHits(object value)
        {
            howManyHits = value;
        }

        public static void Main()
        {
            // TODO Declare a boolean variable named "keepGoing"
            // and assign it a value of "true". Use this variable to 
            // know when to exit the while loop.
            bool keepGoing = true;

            // TODO Define a while loop.
            // Keep looping as long as the variable "keepGoing" has a value of "true".
            while (keepGoing)
            {
                // TODO Prompt the user with the text "Enter a number:" 
                // and assign their value to an "entry" string variable.
                Console.Write("Enter a number: ");
                string entry = Console.ReadLine();

                // TODO If the user entered the text "quit"...
                if (entry == "quit")
                {
                    // TODO Exit the program.
                    keepGoing = false;
                }

                // TODO Else the user didn't enter the text "quit"...
                else
                {
                    // TODO Parse the user's entry to an integer
                    int number = int.Parse(entry);

                    // TODO Square the user's provided number 
                    // (i.e. multiply the number by itself).
                    int result = number * number;

                    // TODO Output the result.
                    // Example: "The square of 2 is 4." or 
                    // "2 multiplied by itself is equal to 4." 
                    Console.WriteLine(number + " multiplied by itself if equal to " + result + ".");
                }
            }

            // TODO Output the text "Goodbye!" after exiting the loop.
            Console.WriteLine("Goodbye!");
        }
    }
}












