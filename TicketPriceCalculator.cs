using System;

class TicketPriceCalculator
{
    static void main()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        int ticketPrice;

        if (age <= 12 || age >= 65)
            ticketPrice = 7;
        else
            ticketPrice = 10;

        Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
    }
}