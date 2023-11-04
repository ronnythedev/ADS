#nullable enable

namespace ADS.MultiplePointers;

public static class PairSumZeroProblem
{
    // STATEMENT OF THE PROBLEM
    // ------------------------
    // A function which accepts a sorted array of integers.
    // The function should find the first pair of numbers where the sum is 0.
    // Return an array that includes both values that sum to zero or null if a pair does not exits.

    public static int[]? SumZero(int[] setOfNumbers)
    {
        if (setOfNumbers.Length <= 0) return null;

        int left = 0;
        int right = setOfNumbers.Length - 1;

        while (left < right)
        {
            int sum = setOfNumbers[left] + setOfNumbers[right];

            if (sum == 0)
            {
                return new int[] { setOfNumbers[left], setOfNumbers[right] };
            }

            if (sum > 0)
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return null;
    }
}

