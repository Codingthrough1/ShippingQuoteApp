using System;

namespace ShippingQuoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask for package weight
            Console.Write("Please enter the package weight: ");
            string weightInput = Console.ReadLine();
            double weight = Convert.ToDouble(weightInput); // Convert input to number

            // Check if package is too heavy
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End the program
            }

            // Ask for width
            Console.Write("Please enter the package width: ");
            string widthInput = Console.ReadLine();
            double width = Convert.ToDouble(widthInput);

            // Ask for height
            Console.Write("Please enter the package height: ");
            string heightInput = Console.ReadLine();
            double height = Convert.ToDouble(heightInput);

            // Ask for length
            Console.Write("Please enter the package length: ");
            string lengthInput = Console.ReadLine();
            double length = Convert.ToDouble(lengthInput);

            // Check if total dimensions are greater than 50
            double dimensionTotal = width + height + length;
            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End the program
            }

            // Calculate the quote:
            // Multiply width * height * length
            double dimensionProduct = width * height * length;

            // Now multiply by the weight
            double rawQuote = dimensionProduct * weight;

            // Divide by 100 to get the final shipping quote
            double quote = rawQuote / 100.0;

            // Display result formatted as dollars
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}
