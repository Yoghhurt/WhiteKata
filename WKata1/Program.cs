//Kata1
class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome, brave adventurer! What is your name?");
        string playerName = Console.ReadLine();
        
        Console.WriteLine($"Greetings, {playerName}! Your journey begins now...");
        
        Console.WriteLine("On a scale of 1 to 10, how excited are you to start this quest?");
        int excitementLevel;
        
        while (!int.TryParse(Console.ReadLine(), out excitementLevel) || excitementLevel < 1 || excitementLevel > 10)
        {
            Console.WriteLine("Please enter a number between 1 and 10.");
        }
        
        if (excitementLevel >= 7)
        {
            Console.WriteLine("Fantastic! You seem ready to take on any challenge!");
        }
        else
        {
            Console.WriteLine("Don't worry, the adventure will be exciting! You'll find your excitement soon enough!");
        }
    }
}
using System;

//Mini-Kata1
class Program
{
    static void Main()
    {
        
        string characterName = "Arin";
        int healthPoints = 100;
        float attackPower = 15.5f;
        bool isParalyzed = true;
        double currencyAmount = 24.75;
        
        Console.WriteLine($"Character Name: {characterName}");
        Console.WriteLine($"Health Points: {healthPoints}");
        Console.WriteLine($"Attack Power: {attackPower}");
        Console.WriteLine($"Is Paralyzed: {isParalyzed}");
        Console.WriteLine($"Gold Coins: {currencyAmount}");
    }
}

