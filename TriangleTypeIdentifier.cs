using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.WriteLine("Enter the lengths of the three sides of the triangle:");

        Console.Write("Side 1: ");
        int side1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Side 2: ");
        int side2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Side 3: ");
        int side3 = Convert.ToInt32(Console.ReadLine());

        // Check for triangle validity
        if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
        {
            if (side1 == side2 && side2 == side3)
                Console.WriteLine("This is an Equilateral triangle.");
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                Console.WriteLine("This is an Isosceles triangle.");
            else
                Console.WriteLine("This is a Scalene triangle.");
        }
        else
        {
            Console.WriteLine("The entered sides do not form a valid triangle.");
        }
    }
}
