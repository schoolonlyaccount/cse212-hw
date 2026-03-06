using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        // Step 1: Create an empty fixed array with the 'length' variable (from the parameters of this function) as its capacity.
        double[] numbers = new double[length];

        // Step 2: Create a for loop (repeats 'length' times) that fills the fixed array with multiples of 'number'. Example: [3, 6, 9, 12, 15]
        for (int i = 0; i < length; ++i)
        {
            numbers[i] = i == 0 ? number : numbers[i - 1] + number;
        }

        // Step 3: Return the filled in array
        return numbers;
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
        // Step 1: Create an empty (temporary) list array
        List<int> temp = new();

        // Step 2: Create a for loop that adds the last 'amount' elements from the original array to the temporary array.
        for (int i = data.Count - amount; i < data.Count; ++i)
        {
            temp.Add(data[i]);
        }

        // Step 3: Create a for loop that adds the elements you skipped previously from the original array to the temporary array.
        for (int i = 0; i < data.Count - amount; ++i)
        {
            temp.Add(data[i]);
        }

        // Step 4: Clear the original array
        data.Clear();

        // Step 5: Add all elements from the temporary array to the original array
        data.AddRange(temp);
    }
}
