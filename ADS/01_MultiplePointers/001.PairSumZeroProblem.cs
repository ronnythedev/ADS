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
        // NAIVE SOLUTION
        // In a "brute-force" solution, we would have to use nested loops:
        // The first loop takes one value, and compares it to each element of the rest of the array in a second loop.
        // The time complexity of this solution would be O(n^2)

        // BETTER SOLUTION
        // *This solution works only if the array is sorted*
        // 1. "left" pointer starts at the beginning of the array
        // 2. "right" pointer starts at the end of the array
        // 3. Sum the values of the two pointers. The following works beacuse the array is sorted (values at the "left" are smaller than values at the "right")
        //      3.1. If the sum is 0, return the two values as the statement of the problem requires.
        //      3.2. If the sum is greater than 0, move the "right" pointer one position to the left.
        //      3.3. If the sum is less than 0, move the "left" pointer one position to the right.

        if (setOfNumbers.Length <= 0) return null;

        int left = 0;
        int right = setOfNumbers.Length - 1;

        while (left < right)
        {
            int sum = setOfNumbers[left] + setOfNumbers[right];

            if (sum == 0) // 🙌
            {
                return new int[] { setOfNumbers[left], setOfNumbers[right] };
            }

            if (sum > 0) // "right" is too big, move it one position to the "left"
            {
                right--;
            }
            else // "left" is too small, move it one position to the "right"
            {
                left++;
            }
        }

        return null;
    }
}

