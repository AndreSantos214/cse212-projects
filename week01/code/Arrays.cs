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
        // My plan to solve this:
        // 1. First, I need a place to store my results. I'll create a new list (an array) that is empty but has the exact size I need, which is 'length'.
        double[] result = new double[length];

        // 2. I need to calculate the multiples one by one. I'll use a loop that repeats 'length' times.
        //    I'll use a counter that starts at 1 and goes up to 'length'.
        for (int i = 1; i <= length; i++)
        {
            // 3. Inside the loop, for each step, I will calculate the multiple.
            //    The math is: the starting 'number' multiplied by my current counter value (1, then 2, then 3, and so on).
            double multiple = number * i;

            // 4. I'll take the result from that multiplication and put it into my list from step 1.
            //    I have to be careful because lists start counting from 0, so the first result goes in spot 0, the second result in spot 1, etc.
            result[i - 1] = multiple;
        }

        // 5. After the loop has finished and my list is full of all the multiples,I'll return the list.
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

        // My plan to solve this:
        // 1. My goal is to take a few items from the END of the list and move them to the START.
        //    The number of items to move is given by 'amount'.
        //    Check for a special case: if the amount to rotate is 0 or the size of the list, the list doesn't change. We can stop here.
        if (amount <= 0 || amount >= data.Count)
        {
            return;
        }

        // 2. I need to find the starting index for the items I want to copy. I will use the formula: startIndex = total number of items - number of items to move. I this way, I get the index of the first item I want to copy.
        //    I'll make a new, temporary list and copy the last 'amount' items from the original list into it. This is like highlighting and copying a piece of text.
        int startIndex = data.Count - amount;
        List<int> itemsToMove = data.GetRange(startIndex, amount);

        // 3. Now that I have a safe copy, I can delete those same items from the end of the original list. This is like cutting the text after you've copied it.
        data.RemoveRange(startIndex, amount);

        // 4. Finally, I'll take the temporary list (with the items I copied) and add all of its
        //    items to the very beginning of the original list. This is like pasting the text at the start of the document.
        data.InsertRange(0, itemsToMove);
    }
}
