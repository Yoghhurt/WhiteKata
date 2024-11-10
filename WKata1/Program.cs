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

//Mini kata 2



class Program
{
    static void Main()
    {
        string name = "Hero";
        int healthPoints = 100;
        float attackPower = 30.5f;
        double experiencePoints = 250.75;
        bool isParalyzed = false;
        double currencyAmount = 150.3333333;

        
        double healthAsDouble = healthPoints;

        
        int attackPowerAsInt = (int)attackPower;

        
        int experienceAsInt = Convert.ToInt32(experiencePoints);

        
        double parsedCurrency = double.Parse("150.3333333");

        
        string invalidInput = "invalid";
        bool parseResult = int.TryParse(invalidInput, out int parsedInteger);
        
        
        Console.WriteLine("Health as double (implicit conversion): " + healthAsDouble);
        Console.WriteLine("Attack Power as int (explicit conversion): " + attackPowerAsInt);
        Console.WriteLine("Experience as int (using Convert): " + experienceAsInt);
        Console.WriteLine("Gold Coins (parsed from string): " + parsedCurrency);
        
        
        if (parseResult)
        {
            Console.WriteLine("Parsing succeeded: " + parsedInteger);
        }
        else
        {
            Console.WriteLine("Parsing failed: '" + invalidInput + "' is not a number.");
        }
    }
}
//Mini kata 3



class Program
{
    static void Main()
    {
        
        Random random = new Random();
        int playerLuck = random.Next(1, 11);  
        
        
        Console.WriteLine("You encounter an enemy! Do you want to attempt an attack? (yes/no)");
        string playerChoice = Console.ReadLine().ToLower();

        
        if (playerChoice == "yes")
        {
            Console.WriteLine("Attempting to attack...");

            
            if (playerLuck > 7)
            {
                Console.WriteLine("Success! Your attack hits the enemy.");
            }
            else if (playerLuck == 6 || playerLuck == 7)
            {
                Console.WriteLine("Barely successful! Your attack just hits the enemy.");
            }
            else
            {
                Console.WriteLine("Missed! Your attack fails to land.");
            }
        }
        else if (playerChoice == "no")
        {
            Console.WriteLine("You decided to retreat.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please type 'yes' or 'no'.");
        }
        
        Console.WriteLine("Your luck value was: " + playerLuck);
    }
}
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
//Kata 4


using System.Threading;  

class Program
{
    static void Main()
    {
        int totalWaves = 3;      
        int enemiesPerWave = 4;  
        
        
        for (int wave = 1; wave <= totalWaves; wave++)
        {
            
            Console.WriteLine($"Wave {wave} is starting!");

            
            for (int enemy = 1; enemy <= enemiesPerWave; enemy++)
            {
                Console.WriteLine($"  Enemy #{enemy} has spawned.");
            }

           
            Console.WriteLine($"Wave {wave} completed. Preparing for the next wave...\n");

            
            Thread.Sleep(2000);  
        }

       
        Console.WriteLine("All waves completed! Victory is yours!");
    }
}

//Final Kata


class Program
{
    static void Main()
    {
        
        int playerHealth = 80;
        int playerAttackPower = 15;
        int playerHealAmount = 10;

        
        int enemyHealth = 50;
        int enemyAttackPower = 10;

        
        while (playerHealth > 0 && enemyHealth > 0)
        {
            
            Console.Clear();  
            Console.WriteLine($"Hero's Health: {playerHealth}");
            Console.WriteLine($"Goblin's Health: {enemyHealth}\n");

            
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            Console.Write("> ");
            string playerChoice = Console.ReadLine();

            if (playerChoice == "1")
            {
                
                Console.WriteLine("\nHero attacks the Goblin!");
                enemyHealth -= playerAttackPower;
                Console.WriteLine($"Goblin takes {playerAttackPower} damage.");
            }
            else if (playerChoice == "2")
            {
                
                Console.WriteLine("\nHero heals!");
                playerHealth += playerHealAmount;
                Console.WriteLine($"Hero regains {playerHealAmount} health.");
            }
            else
            {
                
                Console.WriteLine("\nInvalid choice! Please choose 1 or 2.");
                continue;
            }

            // Check if the enemy is defeated
            if (enemyHealth <= 0)
            {
                Console.WriteLine("\nCongratulations! Hero has defeated the Goblin!");
                break;
            }

            
            Console.WriteLine("\nGoblin attacks Hero!");
            playerHealth -= enemyAttackPower;
            Console.WriteLine($"Hero takes {enemyAttackPower} damage.");

            
            if (playerHealth <= 0)
            {
                Console.WriteLine("\nGame Over! The Goblin has defeated the Hero.");
                break;
            }

            
            Console.WriteLine("\nPress Enter to continue to the next turn...");
            Console.ReadLine();
        }
    }
}
