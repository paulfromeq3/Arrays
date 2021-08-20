using System;


class EntryPoint
{
    static void Main(string[] args)
    {
        // Ouputting arrays in the console
        // Three different ways
        string[] beverages = { "coffee", "cola", "whiskey", "milkshake", "water" };
        for (int i = 0; i < beverages.Length; i++)
        {
            Console.WriteLine(beverages[i]);
        }
    }
}
