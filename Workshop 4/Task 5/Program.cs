using System;

// Enum
enum DayType
{
    Weekday,
    Weekend
}

class Program
{
    static void Main(string[] args)
    {
        // Part 1: Check Weekday or Weekend

        Console.Write("Enter a day: ");
        string day = Console.ReadLine();

        DayType type;

        if (day == "Friday" || day == "Saturday")
        {
            type = DayType.Weekend;
        }
        else
        {
            type = DayType.Weekday;
        }

        Console.WriteLine("It is: " + type);


        // Part 2: Create Book Objects

        Book book1 = new Book(" Basics", "tommy", 500);

        // Change title and price using with expression
        Book book2 = book1 with
        {
            title = "Advanced C#",
            price = 800
        };

        // Print first book
        Console.WriteLine("\nFirst Book:");
        Console.WriteLine(book1);

        // Deconstruct second book
        var (title, author, price) = book2;

        Console.WriteLine("\nSecond Book:");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}