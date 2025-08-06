using System;

class TriangleTypeChecker
{
    // This program was written to identify the type of triangle based on the lengths of its sides
    // It helps users easily determine the triangle type based on side lengths
    static void Main()
    {
        Console.WriteLine("Enter the lengths of the three sides of the triangle:");

        // Prompt user input
        Console.Write("Side 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Side 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Side 3: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Check if sides form a valid triangle using triangle inequality
        if (IsValidTriangle(side1, side2, side3))
        {
            // Determine triangle type
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }
        else
        {
            Console.WriteLine("The given sides do not form a valid triangle.");
        }
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        // Triangle Inequality Theorem
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}
