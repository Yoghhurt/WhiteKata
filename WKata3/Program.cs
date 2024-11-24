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