using System.Collections.Generic;

namespace ADS.MultiplePointers;

public static class AveragePairProblem
{
    // STATEMENT OF THE PROBLEM
    // ------------------------
    // Write a function called averagePair. Given a sorted array of integers and a target average, 
    // determine if there is a pair of values in the array where the average of the pair equals the target average.

    public static bool AveragePair(int[] setOfNumbers, decimal target)
    {
        // NAIVE SOLUTION
        // We would need two nested loops:
        // The first loop would take one value of the array and compute the average with each item
        // of the rest of the array (in a second loop).  
        // When "target" equals the computed average, return true.
        // At the end of the function, return false (if the pair doesn't exist, it will get until the end of the function)

        // BETTER SOLUTION
        // Loop one time over the set of numbers
        // Keep track of each "visited" value in a dictionary.
        // In each iteration, find the other "required" value to get the target average.
        // Check if that "required" value is in the dictionary, if so, return true
        // At the end of the function, return false.

        if (setOfNumbers.Length == 0)
        {
            return false;
        }

        var visitedValues = new Dictionary<decimal, bool>();

        for (var i = 0; i < setOfNumbers.Length; i++)
        {
            var requiredValue = (target * 2) - setOfNumbers[i];

            if (visitedValues.ContainsKey(requiredValue))
            {
                return true;
            }

            if (!visitedValues.ContainsKey(setOfNumbers[i]))
            {
                visitedValues.Add(setOfNumbers[i], true);
            }
        }

        return false;
    }
}

