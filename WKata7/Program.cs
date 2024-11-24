// kata 3
class Program
{
    static void Main()
    {
        
        Random random = new Random();
        int playerLuck = random.Next(1, 11);  

        
        Console.WriteLine("You find a mysterious treasure chest! What will you do?");
        Console.WriteLine("1. Open the chest");
        Console.WriteLine("2. Ignore the chest");
        Console.WriteLine("3. Leave the area");
        Console.Write("> ");
        
        string choice = Console.ReadLine().Trim();  
        
        
        switch (choice)
        {
            case "1":
                Console.WriteLine("You try to open the chest...");
                if (playerLuck > 7)
                {
                    Console.WriteLine("Success! The chest contains a rare gem.");
                }
                else if (playerLuck >= 5)
                {
                    Console.WriteLine("You found some gold!");
                }
                else
                {
                    Console.WriteLine("The chest was trapped! You narrowly escape.");
                }
                break;

            case "2":
                Console.WriteLine("You decide to ignore the chest and continue on your journey.");
                break;

            case "3":
                Console.WriteLine("You leave the area, and the mystery remains unsolved.");
                break;

            default:
                Console.WriteLine("Invalid choice! Please enter 1, 2, or 3.");
                break;
        }

        
        Console.WriteLine($"Your luck value was: {playerLuck}");
    }
}