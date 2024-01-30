using System;
using System.Collections.Generic;

namespace ADS;

public class LongestSubstringWithKDistinctCharsProblem
{
    // STATEMENT OF THE PROBLEM
    // ------------------------
    // Given a string, find the length of the longest substring in it with no more
    // than "k" distinct characters

    public static int GetLongestSubstringK(string stringOfCharacters, int k)
    {
        // NAIVE SOLUTION
        // Create two nested loops
        // Take one item from in the first loop and compare it with each item
        // of the rest of string in the nested loop keeping a counter and mapping visted characters

        // BETTER SOLUTION
        // In a single loop, keep two pointers
        // Keep track of every every character frequency
        // When the number of "visited" characters is greater than "k"
        // start shrinking the window at the left (consider frequency of characters before removing the item from the dictionary)
        // Compare the current size of the window with the maxLength

        var charFrequency = new Dictionary<char, int>();

        var maxLength = -1;
        var upperPointer = 0;
        var lowerPointer = 0;

        while (upperPointer < stringOfCharacters.Length)
        {
            var currentChar = stringOfCharacters[upperPointer];

            if (charFrequency.ContainsKey(currentChar))
            {
                charFrequency[currentChar]++;
            }
            else
            {
                charFrequency[currentChar] = 1;
            }


            while (charFrequency.Count > k)
            {
                var leftChar = stringOfCharacters[lowerPointer];
                charFrequency[leftChar]--;

                if (charFrequency[leftChar] == 0)
                {
                    charFrequency.Remove(leftChar);
                }

                lowerPointer++;
            }

            var windowSize = upperPointer - lowerPointer + 1;

            if (windowSize > maxLength)
            {
                maxLength = windowSize;
            }

            upperPointer++;
        }

        return maxLength;

    }
}
