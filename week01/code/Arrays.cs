public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Steps:
        // 1. Create an array with the desired length.
        // 2. Use a loop to go through each position in the array.
        // 3. Multiply the number by the current position + 1.
        // 4. Store the result in the array.
        // 5. Return the completed array.

        // We make the array to have the result on length.
        var result = new double[length];

        // with a for loop we can iterate the length used and we are ready 
        // to multiply the number with that index and add it to the array.
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
            
        }
        
        return result;
    }


    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Steps:
        // Create a new list to run
        // use for loop to iterate the data list and add elements on the new list with another order rotation

        var rotateList = new List<int>();
        for (int i = 0; i < data.Count; i++)
        {
            rotateList.Add(data[(data.Count - amount + i) % data.Count]);
        }

        // Clear the original list and add all elements from the rotated list
        data.Clear();
        data.AddRange(rotateList);
    }
}
