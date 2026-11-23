using Task_3;


class Program
{
    static void Main(string[] args)
    {
        // Create object
        ParameterDemo obj = new ParameterDemo();

        // 1. Ref parameter
        int number = 10;

        obj.Increase(ref number);

        Console.WriteLine("Increased Number: " + number);

        // 2. Out parameter
        string fullname;

        obj.GetFullName(out fullname);

        Console.WriteLine("Full Name: " + fullname);

        // 3. Params parameter
        int result = obj.SumAll(10, 20, 30, 40);

        Console.WriteLine("Sum: " + result);
    }
}