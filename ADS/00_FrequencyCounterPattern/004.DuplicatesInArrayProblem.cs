using System;
using System.Collections.Generic;

namespace ADS.FrequencyCounterPattern;

public static class DuplicatesInArrayProblem
{
    // STATEMENT OF THE PROBLEM
    // ------------------------
    // Given list of numbers, find out if there are duplicates.

    public static bool ThereAreDuplicates(int[] listOfNumbers)
    {
        // NAIVE SOLUTION
        // Might use nested loops to compare each item with all the rest of items in the array
        // Return false if one value is found in the second array

        // BETTER SOLUTION
        // In a single looop, save in a dictionary each "visited" value.
        // The key of such dictionary will be the value of the item, and the value of the dictionary will be the index in the array
        // In each iteration, compare the value with "visited" values in the dictionary and compare
        // return false if the current value exist in the dictionary

        var visitedItems = new Dictionary<int, int>();

        if (listOfNumbers.Length == 0)
        {
            return false;
        }

        for (var i = 0; i < listOfNumbers.Length; i++)
        {
            var currentValue = listOfNumbers[i];

            if (visitedItems.ContainsKey(currentValue))
            {
                return true;
            }

            visitedItems.Add(currentValue, i);
        }

        return false;
    }
}
