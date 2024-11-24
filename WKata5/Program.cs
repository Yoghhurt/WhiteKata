//Kata 2
class Program
{
    static void Main()
    {
        
        string name = "Lira";
        int level = 5;
        float healthPoints = 75.5f;
        double experiencePoints = 1025.75;
        bool magicAbility = true;
        char rank = 'A';

        
        Console.WriteLine("Character Name: " + name);
        Console.WriteLine("Level: " + level);
        Console.WriteLine("Health Points: " + healthPoints);
        Console.WriteLine("Experience Points: " + experiencePoints);
        Console.WriteLine("Has Magic Ability: " + magicAbility);
        Console.WriteLine("Rank: " + rank);

        
        double pointsToNextLevel = level * 100 + (level * 10 * 0.25);
        
       
        Console.WriteLine("Points needed to reach next level: " + pointsToNextLevel);
    }
}