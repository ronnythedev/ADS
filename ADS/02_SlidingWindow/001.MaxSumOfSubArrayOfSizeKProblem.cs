namespace ADS.SlidingWindow;

public static class MaxSumOfSubArrayOfSizeKProblem
{
    // STATEMENT OF THE PROBLEM
    // ------------------------
    // Given an array of positive numbers and a positive number ‘k’,
    // find the maximum sum of any contiguous subarray of size ‘k’.

    public static int? MaxSumOfSubArrayOfSizeKSolution(int k, int[] arr)
    {
        // NAIVE SOLUTION
        // Create two nested loops, the first one will go over the array one time.
        // For each iteration in the first loop, the second loop will go forward "k" spaces making the sum of this subset of values.
        // Compare the new sum with the prior sum and keep the greater.
        // For each iteration of the first loop, there will be another loop with "k" iterations.

        // BETTER SOLUTION
        // In one loop, make the sum of the first "k" numbers and save that sum.
        // In a different loop start a "window" of size "k" one index ahead of the first loop
        // This "window" will "slide" one position at a time (in each iteration)
        // In each "slide" (iteration), rest the first index of the previous window and add the new index of the new window
        // Compare the new result and keep the greater

        if (arr.Length == 0 || arr.Length < k)
        {
            return null;
        }

        int maxSum = 0;
        for (var i = 0; i < k; i++)
        {
            maxSum += arr[i];
        }

        int tempSum = maxSum;
        for (var i = k; i < arr.Length; i++)
        {
            tempSum = tempSum + arr[i] - arr[i - k];

            if (tempSum > maxSum)
            {
                maxSum = tempSum;
            }
        }

        return maxSum;
    }
}