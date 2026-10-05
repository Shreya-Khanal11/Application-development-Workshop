using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 42, 7, 19, 3, 88 };

        Array.Sort(numbers);

        Array.Reverse(numbers);

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        int position = Array.IndexOf(numbers, 19);
        Console.WriteLine("Position of 19: " + position);
    }
}