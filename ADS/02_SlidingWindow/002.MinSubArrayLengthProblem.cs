namespace ADS.SlidingWindow;

public static class MinSubArrayLengthProblem
{
    // STATEMENT OF THE PROBLEM
    // ------------------------
    // Write a funtion called GetMinSubarrayLength which accepts an array of positive integers
    // and a positive integer "k"
    // Return the minimal length of a contiguos subarray of which the sum is greater than or equal to "k"

    public static int GetMinSubarrayLength(int[] listOfNumbers, int k)
    {
        // NAIVE SOLUTION

        // BETTER SOLUTION
        // 1. Always use a while loop with the "lowerPointer" and the length - 1 of the array
        // 2. Always increase "upperPointer" at the end of the loop
        // 3. The body of the while loop will always compute something (in this case a sum) 
        // and must have a "reset" validation (in this case if sum >= k)
        // 4. In the reset area, usually "upperPointer" will point to current "lowerPointer"
        // and "lowerPointer" will increase in one.
        // 5. In this pattern, "lowerPointer" will increase slowly while "upperPointer" will increase faster
        // but "upperPointer" will be "reset" several times during the execution

        if (listOfNumbers.Length == 0)
        {
            return 0;
        }

        var minLength = listOfNumbers.Length;
        var lowerPointer = 0;
        var upperPointer = 0;
        var lengthCounter = 0;
        int sum = 0;

        while (lowerPointer < listOfNumbers.Length)
        {
            lengthCounter++;
            sum += listOfNumbers[upperPointer];

            if (sum >= k)
            {
                if (lengthCounter < minLength)
                {
                    minLength = lengthCounter;
                }

                upperPointer = lowerPointer;
                lowerPointer++;
                lengthCounter = 0;
                sum = 0;
            }

            if (upperPointer < listOfNumbers.Length - 1)
            {
                upperPointer++;
            }
        }

        return (minLength == listOfNumbers.Length) ? 0 : minLength;

    }
}