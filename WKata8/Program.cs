//Kata 4
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