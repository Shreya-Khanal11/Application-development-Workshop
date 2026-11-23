using System;
class Program
{
    static void Main()
    {
        byte myByte = 255;
        short myShort = 32000;
        int myInt = 100;
        long myLong = 9000000000L;
        float myFloat = 3.14f;
        double myDouble = 3.14159;
        decimal myDecimal = 19.99m;
        char myChar = 'A';
        bool myBool = true;

        // 2. Convert integer 42 to a string
        int number = 42;
        string numberString = number.ToString();

        // 3. Convert string "3.14" to a double
        string piString = "3.14";
        double piDouble = Convert.ToDouble(piString);

        Console.WriteLine($"byte: {myByte}");
        Console.WriteLine($"short: {myShort}");
        Console.WriteLine($"int: {myInt}");
        Console.WriteLine($"long: {myLong}");
        Console.WriteLine($"float: {myFloat}");
        Console.WriteLine($"double: {myDouble}");
        Console.WriteLine($"decimal: {myDecimal}");
        Console.WriteLine($"char: {myChar}");
        Console.WriteLine($"bool: {myBool}");
        Console.WriteLine($"Converted int 42 to string: {numberString}");
        Console.WriteLine($"Converted string \"3.14\" to double: {piDouble}");
    }
}