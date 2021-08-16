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
        // Trying to access an index higher than the number of elements causes an exception


        // Create an array of temperatures
        // First approach: create an empty array of a set number of values.
        // Reminder:
        //   - control-k-c = comment the highlighted code
        //   - control-u-c = uncomment the highlighted code

        double[] temperatures = new double[5];
        temperatures[0] = 99.0;
        temperatures[1] = 110.2;
        temperatures[2] = 107.4;
        temperatures[3] = 78.0;
        temperatures[4] = 88.1;
        Console.WriteLine(temperatures[2]);


        // Second approach: assign values when you create the array.
        double[] temperaturesUK = { 32.0, 33.0, 43.0, 22.0, 35.4 };
        Console.WriteLine(temperaturesUK[2]);



    }
}