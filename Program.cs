using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Requirement 1: Display the required welcome message on the first line
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Requirement 2: Prompt the user to enter the package weight
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Requirement 3: Check if the weight is greater than 50
            if (weight > 50)
            {
                // Display error message and end the program if too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Exits the Main method, ending the program
            }

            // Requirement 4: Prompt the user for the package width
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            // Requirement 5: Prompt the user for the package height
            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            // Requirement 6: Prompt the user for the package length
            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            // Requirement 7: Check if the total of the dimensions (width + height + length) is greater than 50
            if ((width + height + length) > 50)
            {
                // Display error message and end the program if too big
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Exits the Main method, ending the program
            }

            // Requirement 8: Multiply the three dimensions (height, width, & length) together, 
            // multiply the product by the weight, and divide the outcome by 100.
            double quote = (height * width * length * weight) / 100;

            // Requirements 9 & 10: Display the quote to the user as a formatted dollar amount with two decimal places
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

            // Friendly closing statement
            Console.WriteLine("Thank you!");
        }
    }
}
