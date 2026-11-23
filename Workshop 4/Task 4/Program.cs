using Task_4;

class Program
{
    static void Main(string[] args)
    {
        // Object using default constructor
        Player p1 = new Player();

        // Object using parameterized constructor
        Player p2 = new Player("Hazel", 5, 100);

        // Display first player
        Console.WriteLine("\nFirst Player:");
        Console.WriteLine("Name: " + p1.playerName);
        Console.WriteLine("Level: " + p1.level);
        Console.WriteLine("Health: " + p1.health);

        // Display second player
        Console.WriteLine("\nSecond Player:");
        Console.WriteLine("Name: " + p2.playerName);
        Console.WriteLine("Level: " + p2.level);
        Console.WriteLine("Health: " + p2.health);
    }
}