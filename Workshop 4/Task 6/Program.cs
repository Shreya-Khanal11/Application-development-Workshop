using System;

class Program
{
    static void Main(string[] args)
    {
        // Get marks from user
        Console.Write("Enter your marks: ");
        int.TryParse(Console.ReadLine(), out int marks);

        // Get total marks
        Console.Write("Enter total marks: ");
        int.TryParse(Console.ReadLine(), out int total);

        // Breakpoint 1: Before calculation

        //double percentage = marks / total * 100;

        // Breakpoint 2: After calculation
        double percentage = (double)marks / total * 100;

        Console.WriteLine("Percentage: " + percentage);
    }
}