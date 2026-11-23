

using Task_2;

class Program
{
    static void Main(string[] args)
    {
        // Create object
        Calculator cal = new Calculator();

        // Call welcome method
        cal.PrintWelcome();

        // Call Add method
        int sum = cal.Add(10, 20);
        Console.WriteLine("Addition: " + sum);

        // Call Multiply method with two numbers
        int result1 = cal.Multiply(5, 4);
        Console.WriteLine("Multiplication: " + result1);

        // Call Multiply method with one number
        int result2 = cal.Multiply(5);
        Console.WriteLine("Multiplication with default value: " + result2);
    }
}