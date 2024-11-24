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