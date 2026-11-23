
using Task_1;

class Program
{
    static void Main(string[] args)
    {
        student s1 = new student();
        student s2 = new student();

        s1.name = "Jenni";
        s1.age = 20;
        s1.address = "Dharan";

        s2.name = "Shreya";
        s2.age = 20;
        s2.address = "Itahari";

        Console.WriteLine("First Student:");
        Console.WriteLine(s1.name);
        Console.WriteLine(s1.age);
        Console.WriteLine(s1.address);

        Console.WriteLine("\nSecond Student:");
        Console.WriteLine(s2.name);
        Console.WriteLine(s2.age);
        Console.WriteLine(s2.address);

        Console.WriteLine("\nCollege: " + student.college);
    }
}