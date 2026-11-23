using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List of fruits
        List<string> fruits = new List<string> { "Kiwi", "Dragon Fruit", "Mango" };
        fruits.Add("Orange");
        fruits.Remove("Banana");

        foreach (string f in fruits)
            Console.WriteLine(f);

        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(1, "Dragon Fruit");
        dict.Add(2, "Mango");
        dict.Add(3, "Kiwi");
        dict.Add(4, "Orange");

        foreach (var d in dict)
            Console.WriteLine(d.Key + " = " + d.Value);
    }
}