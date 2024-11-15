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
        // First you need to make a Double array as the result with the size of the variable length
        // next you need to create a double that represents the multiple and set it equal to the number
        // Now that is finished you create a for loop to loop in the amount of times of the length.
            // Now you add the double multiple to the result array
            // After you add the double you need to add multiple with number
        double[] result = new double[length];
        double multiple = number;
        for(int i = 0; i < length; i++){
            result[i] = multiple;
            multiple = multiple + number;
        }

        return result; // replace this return statement with your own
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
        // First you need to create a for loop with the i being less than the amount because that is how many spaces we are moving over
        // In the for loop for each item we are moving over we need to store that value in an int. So we need to create an int value with the last value in the data list
        // Once the data is stored to a variable we need to remove that value from the end of the list using the RemoveAt class
        // Once the value is removed, we need to store the saved value and add it to the front of the list. 
        for(int i = 0; i < amount; i++){
            int value = data[data.Count()-1];
            data.RemoveAt(data.Count()- 1);
            data.Insert(0, value);
        }
    }
}
