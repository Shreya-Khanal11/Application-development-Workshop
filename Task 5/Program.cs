using System;

class Program
{
    static void Main()
    {
        DateTime birthDate = new DateTime(2007, 7, 31);

        DateTime currentDate = DateTime.Now;

        //  Calculating age using TimeSpan
        TimeSpan difference = currentDate - birthDate;
        int ageInYears = difference.Days / 365;

        Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
        Console.WriteLine($"Current Date: {currentDate}");
        Console.WriteLine($"Age: {ageInYears} years");

        //  Adding 10 days to birthdate and print
        DateTime newDate = birthDate.AddDays(10);
        Console.WriteLine($"\nBirthdate + 10 days: {newDate.ToShortDateString()}");
    }
}