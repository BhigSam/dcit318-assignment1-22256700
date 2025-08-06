using System;

class GradeCalculator
{
    // This is written to calculate the letter equivalent of student grades
    //Tomake grade calculation very simple for users
    static void Main()
    {
        Console.WriteLine("Enter a numerical grade between 0 and 100:");

        // Read input and validate
        string input = Console.ReadLine();
        if (int.TryParse(input, out int grade))
        {
            if (grade >= 0 && grade <= 100)
            {
                string letterGrade;

                if (grade >= 90)
                    letterGrade = "A";
                else if (grade >= 80)
                    letterGrade = "B";
                else if (grade >= 70)
                    letterGrade = "C";
                else if (grade >= 60)
                    letterGrade = "D";
                else
                    letterGrade = "F";

                Console.WriteLine($"The letter grade is: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Grade must be between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

