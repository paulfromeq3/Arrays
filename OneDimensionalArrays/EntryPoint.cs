using System;


class EntryPoint
{
    static void Main(string[] args)
    {
        // Ouputting arrays in the console
        // Three different ways
        string[] beverages = { "coffee", "cola", "whiskey", "milkshake", "water" };
        Console.WriteLine("The available for loop beverages are:");

        for (int i = 0; i < beverages.Length; i++)
        {
            Console.WriteLine($"  {beverages[i]}");  // If you used string formatting you can line up the output right-aligned.
        }

        // Add a quick separator, try to hang onto that learning!
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("\nThe available foreach loop beverages are:");
        
        // You can usually use the 'item' variable that's automatecally generated to identify you're getting an item from the array.
        // In this case, you can change the name to 'beverage' to easily identify that you're getting a beverage item from the beverages array.
        foreach (var beverage in beverages)  
        {
            Console.WriteLine($"  {beverage}");

        }

        // Third method uses "join" for only strings
        // string.Join()
        Console.WriteLine("\nThe available string.Join() method beverages are:");
        Console.WriteLine(string.Join("  ", beverages));
        // You can assign the output to a variable
        string joinedArray = string.Join("  ", beverages);
        Console.WriteLine(joinedArray);
        Console.WriteLine();
        // string.Join() turns a string array into one single string value

        // Challenge
        // My solution, not very elegant
        // How do I put the values in the arrays and not have all those zeros?
        //
        // Create 4 integer arrays
        // Only creating 40 random numbers, but don't know how many will be in each level.
        // So all of the variables get allowcated 40 values
        int[] levelOne = new int[40];
        int[] levelTwo = new int[40];
        int[] levelThree = new int[40];
        int[] levelFour = new int[40];

        // Start of the Random number generator
        Random rnd = new Random();
        int indexA = 0;
        int indexB = 0;
        int indexC = 0;
        int indexD = 0;

        // The loop to create 40 random integers
        for (int i = 0; i < 40; i++)
        {
            int randomBetweenOneAndForty = rnd.Next(1, 40);
            int simpleCase = randomBetweenOneAndForty / 10;
            switch (simpleCase)
            {
                case 0:
                    levelOne[indexA] = randomBetweenOneAndForty;
                    indexA++;
                    break;
                case 1:
                    levelTwo[indexB] = randomBetweenOneAndForty;
                    indexB++;
                    break;
                case 2:
                    levelThree[indexC] = randomBetweenOneAndForty;
                    indexC++;
                    break;
                default:
                    levelFour[indexD] = randomBetweenOneAndForty;
                    indexD++;
                    break;
            }
        }

        foreach (var item in levelOne)
        {
            Console.WriteLine("Low temps: " + item);
        }
        Console.WriteLine();

        foreach (var item in levelTwo)
        {
            Console.WriteLine("Medium-Low temps: " + item);
        }
        Console.WriteLine();

        foreach (var item in levelThree)
        {
            Console.WriteLine("Medium-High temps: " + item);
        }
        Console.WriteLine();

        foreach (var item in levelFour)
        {
            Console.WriteLine("High temps: " + item);

        }
    }
}
