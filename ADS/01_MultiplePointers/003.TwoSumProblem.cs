using System.Collections.Generic;

namespace ADS.MultiplePointers;

public static class TwoSumProblem
{
    // STATEMENT OF THE PROBLEM
    // ------------------------
    // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    // You may assume that each input would have exactly one solution, and you may not use the same element twice.
    // You can return the answer in any order.

    public static int[] TwoSum(int[] setOfNumbers, int target)
    {
        // NAIVE SOLUTION
        // We would need two nested loops:
        // The first loop would take one value of the array and sum it to the rest of items of the array (in a second loop) when "target" is found, return the indexes of the two loops

        // BETTER SOLUTION
        // Loop one time over the set of numbers
        // Keep track of each "visited" item with its index saving it into the dictionary. The key will be the value in the array, and the value will be the index of the array
        // In each iteration, find the "missing value" to sum up to "target"
        // Check if the "missing value" is in the dictionary, if so, return the indexes

        if (setOfNumbers.Length == 0)
        {
            return System.Array.Empty<int>();
        }

        var vistedValues = new Dictionary<int, int>();

        for (var i = 0; i < setOfNumbers.Length; i++)
        {
            var currentValue = setOfNumbers[i];
            var missingValue = target - currentValue;

            if (vistedValues.ContainsKey(missingValue))
            {
                var firstIndex = vistedValues[missingValue];

                return new int[] { firstIndex, i };
            }

            vistedValues.Add(currentValue, i);
        }

        return System.Array.Empty<int>();
    }
}

