namespace Task_2;

public class Calculator
{
    // Void method
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    // Addition method
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // Multiplication method with optional parameter
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }
}