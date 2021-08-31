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

        // Second way
        // Use the Array.Copy() method
        // Used to copy values from the first array into the second array
        // The main difference between this and the array.Clone() method is that
        // the Array.Copy() method requires you to already have an array setup to receive the values.

        array[2] = 3;  // set the index element back to the original value


        int[] secondWayToCloneAnArray = new int[array.Length];
        // That statement creates a new integer array the same length as the array "array[]"

        // You need the name of the source array, the destination array, length (how many elements you want to copy from the first array to the second array.
        // If you want to copy the whole array, use array.Length
        // If you ran this code...
        Array.Copy(array, secondWayToCloneAnArray, 3);
        // It would copy over only the first three elements in the array.

        Array.Copy(array, secondWayToCloneAnArray, array.Length);


        // Let's see what happens...
        Console.WriteLine("\n\nSecond way to correctly clone an array.");
        Console.WriteLine("array[2] = " + array[2]);
        Console.WriteLine("secondWayToCloneAnArray[2] = " + secondWayToCloneAnArray[2]);
        Console.WriteLine("\nNow change the value of array[2] to 999999 and it is reflected in the second array automatically.");
        array[2] = 999999;
        Console.WriteLine("array[2] = " + array[2]);
        Console.WriteLine("firstWayToCloneAnArray[2] = " + firstWayToCloneAnArray[2]);

    }

    static void ArrayCopy()
    {

    }
}
