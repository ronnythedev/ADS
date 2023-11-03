﻿using System.Collections.Generic;

namespace ADS.FrequencyCounterPattern;

public static class ArrayContainingSquaredValuesProblem
{
    // STATEMENT OF THE PROBLEM
    // ------------------------
    // Develop a function that takes two input arrays. 
    // The function should determine whether each element in the first array has its counterpart, squared, in the second array. 
    // Additionally, the frequency of occurrence for each value in the first array must match the frequency of the squared value in the second array. 
    // The function must return a boolean value TRUE if the aforementioned conditions are met, or FALSE otherwise.

    public static bool SameSquared(int[] array1, int[] array2)
    {
        // In a "brute-force" solution, we would have to use nested loops to compare each element in the first array with each element in the second array.
        // The time complexity of this solution would be O(n^2), which is not ideal.
        // A better solution would be to use a frequency counter pattern.

        // If the length of the two arrays is different, we can return false immediately.
        if (array1.Length != array2.Length)
        {
            return false;
        }

        // We create two dictionaries to store the frequency of each value in the two arrays.
        var frequencyCounter1 = new Dictionary<int, int>();
        var frequencyCounter2 = new Dictionary<int, int>();

        // We iterate through each array and store the frequency of each value in the corresponding dictionary.
        foreach (var value in array1)
        {
            frequencyCounter1[value] = frequencyCounter1.GetValueOrDefault(value, 0) + 1;
        }

        foreach (var value in array2)
        {
            frequencyCounter2[value] = frequencyCounter2.GetValueOrDefault(value, 0) + 1;
        }

        // We iterate through the first dictionary and check whether the squared value of each key is present in the second dictionary. 
        // If it is not, we return false immediately.
        foreach (var key in frequencyCounter1.Keys)
        {
            if (!frequencyCounter2.ContainsKey(key * key))
            {
                return false;
            }

            // We also check whether the frequency of each key in the first dictionary matches the frequency of the squared value in the second dictionary.
            if (frequencyCounter1[key] != frequencyCounter2[key * key])
            {
                return false;
            }
        }

        return true;
    }
}

