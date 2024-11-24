//Mini Kata 4
class Program
{
    static void Main()
    {
        
        Console.WriteLine("Spawning enemies using a for loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Enemy #{i} spawned!");
        }

        
        Console.WriteLine("\nSpawning enemies using a while loop:");
        int enemyCount = 1;
        while (enemyCount <= 3)
        {
            Console.WriteLine($"Enemy #{enemyCount} spawned!");
            enemyCount++;
        }
    }
}