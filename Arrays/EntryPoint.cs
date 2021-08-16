using System;

class EntryPoint
{
    static void Main()
    {
        // An array is basically a container for a set amount of values.
        // You can have arrays of different types
        // Access any value in an array using its index.
        // Indices always start at zero.
        // Trying to access an index which isn't assigned a value returns a zero.

        // Trying to access an index of a string array which isn't assigned a value returns a null value.
        // Trying to access an index higher than the number of elements causes an exception


        // Create an array of temperatures
        // First approach: create an empty array of a set number of values.
        // Reminder:
        //   - control-k-c = comment the highlighted code
        //   - control-u-c = uncomment the highlighted code

        double[] temperatures = new double[5];
        temperatures[0] = 99.0;
        temperatures[1] = 110.2;
        //temperatures[2] = 107.4;
        temperatures[3] = 78.0;
        temperatures[4] = 88.1;
        Console.WriteLine(temperatures[2]);


        // Second approach: assign values when you create the array.
        double secondTemp = 33.0;
        double[] temperaturesUK = { 32.0, secondTemp, 43.0, 22.0, 35.4 };
        Console.WriteLine(temperaturesUK[3]);

        // An example of a character array.
        // Char variables and arrays use single quotes for the values.
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f' };
        for (int i = 0; i < alphabet.Length; i++)
        {
            Console.WriteLine(alphabet[i]);
        }

        // Populating random temperatures into an array
        // rng is commonly used as a variable name for your random number generator
        double minRange = 35.0;
        double maxRange = 40.0;

        double[] tempsGenerated = new double[5];
        Random rng = new Random();

        // Reminder: the index starts at zero so array length is always one more than the index.
        // This isn't a problem with the for loop because it says while i is LESS than the length.
        for (int i = 0; i < tempsGenerated.Length; i++)
        {
            // tempsGenerated[i] = rng.NextDouble();  // Generates a random number between 0.0 and 1.0
            // tempsGenerated[i] = minRange + (maxRange - minRange) * rng.NextDouble();  // This is how to get a random number in certain range
            // Now input the value from the console.

            Console.Write($"Please input a number for index[{i}]: ");
            tempsGenerated[i] =  Convert.ToDouble(Console.ReadLine()); // Reminder: must convert the input from string to double;
            Console.WriteLine(tempsGenerated[i]);

        }

        // You can't use a foreach loop to assign values to an array.
        // Use a foreach loop to iterate over an array.
        




    }
}