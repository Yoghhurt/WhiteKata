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