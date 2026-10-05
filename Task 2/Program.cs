using Task_2;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("PI = " + Circle.PI);

        Circle.PI = 3.141559; // Compilation error: Cannot assign a new value to Circle.PI because it is declared as a 'const' (read-only).
    }

}



