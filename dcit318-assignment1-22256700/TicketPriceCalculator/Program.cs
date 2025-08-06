using System;

class Program
{
    static void Main()
    {
        // Prompt the user for their age
        // This program calculates the ticket price based on age to help users easily determine their ticket costs the prices of their tickets
        Console.Write("Please enter your age: ");
        string input = Console.ReadLine();

        // Try to parse the input to an integer
        if (int.TryParse(input, out int age))
        {
            // Validate that age is non-negative
            if (age < 0)
            {
                Console.WriteLine("Age cannot be negative.");
            }
            else
            {
                // Determine ticket price
                int ticketPrice = (age <= 12 || age >= 65) ? 7 : 10;

                // Display the result
                Console.WriteLine($"Your ticket price is: ${ticketPrice}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for age.");
        }

        // Pause the console so the user can see the result
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
