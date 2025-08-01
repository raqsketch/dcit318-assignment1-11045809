using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        double sideA = ReadSideLength("A");
        double sideB = ReadSideLength("B");
        double sideC = ReadSideLength("C");

        if (sideA == sideB && sideB == sideC)
            Console.WriteLine("The triangle is Equilateral.");
        else if (sideA == sideB || sideB == sideC || sideA == sideC)
            Console.WriteLine("The triangle is Isosceles.");
        else
            Console.WriteLine("The triangle is Scalene.");
    }

    static double ReadSideLength(string sideName)
    {
        double sideLength;
        while (true)
        {
            Console.Write($"Enter the length of side {sideName}: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && double.TryParse(input, out sideLength))
            {
                return sideLength;
            }
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
       
