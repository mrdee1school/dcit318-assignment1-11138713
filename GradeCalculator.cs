using System;

class GradeCAlculator
{
    static void main()
    {
        Console.Write("Enter your score (0-100): ");
        int score = Convert.ToInt32(Console.ReadLine());

        string grade;

        if (score >= 90) grade = "A";
        else if (score >= 80) grade = "B";
        else if (score >= 70) grade = "C";
        else if (score >= 60) grade = "D";
        else grade = "F";

        Console.WriteLine($"You grade is {grade}");
    }
}