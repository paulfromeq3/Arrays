using System;

class EntryPoint
{
    static void Main()
    {
        // Reminder: Arrays are reference types
        //

        int[] array = { 1, 2, 3, 4, 5 };

        // Create a second array with the same values
        // A normal variable would just have a direct assignment
        // You would think it would look like this:

        int[] wrongWayToCopyAnArray = array;

        Console.WriteLine("array[2] = " + array[2]);
        Console.WriteLine("wrongWayToCopyAnArray[2] = " + wrongWayToCopyAnArray[2]);
        Console.WriteLine("\nNow change the value of array[2] to 999999 and it is reflected in the second array automatically.");
        array[2] = 999999;
        Console.WriteLine("array[2] = " + array[2]);
        Console.WriteLine("wrongWayToCopyAnArray[2] = " + wrongWayToCopyAnArray[2]);
        // This happens because arrays are reference types.
        // When array[] was created, it received a block of memory for its values.
        // When wrongWayToCopyAnArray[] was created, it didn't get a new block of memory.
        // It just points to the block of memory assigned to array[].
        // So anything that happens to array[] gets reflected in wrongWayToCopyAnArray[].

        // Two ways to create a clone of an array.
        // First, use the array.Clone() method.
        // You have to clone it and typecast it.
        // Looks like -->  (typecasting[])array.Clone()
        // (int[])array.Clone()

        array[2] = 3;
        int[] firstWayToCloneAnArray = (int[])array.Clone();

        // Let's see what happens...
        Console.WriteLine("\n\nFirst way to correctly clone an array.");
        Console.WriteLine("array[2] = " + array[2]);
        Console.WriteLine("firstWayToCloneAnArray[2] = " + firstWayToCloneAnArray[2]);
        Console.WriteLine("\nNow change the value of array[2] to 999999 and it is reflected in the second array automatically.");
        array[2] = 999999;
        Console.WriteLine("array[2] = " + array[2]);
        Console.WriteLine("firstWayToCloneAnArray[2] = " + firstWayToCloneAnArray[2]);




    }
}
