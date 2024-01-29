using System.Collections.Generic;
using System.Data.SqlTypes;

namespace ADS.SlidingWindow;

public static class LongestSubstringProblem
{
    // STATEMENT OF THE PROBLEM
    // ------------------------
    // Write a function called GetLongestSubstring, which accepts a string
    // and returns the length of the longest substring with all distinct characters

    public static int GetLongestSubstring(string stringOfCharacters)
    {
        // NAIVE SOLUTION
        // Create two nested loops
        // Take one item from in the first loop and compare it with each item
        // of the rest of string in the nested loop keeping a counter

        // BETTER SOLUTION
        // In a single loop, keep two pointers
        // Keep track of every "visited" value in a dictionary
        // While the upperPointer increases, check if the value is alaredy in the dictionary
        // Keep a counter of current length and in another variable the max length
        // The "reset" part in the loop, will compare the max length, reset the upper pointer,
        // increase the lower pointer and clear the dictionary

        var visitedValues = new Dictionary<char, bool>();

        var maxLength = 0;
        var lowerPointer = 0;
        var upperPointer = 0;
        var lengthCounter = 0;

        while (lowerPointer < stringOfCharacters.Length)
        {
            var character = stringOfCharacters[upperPointer];

            if (visitedValues.ContainsKey(character))
            {
                if (lengthCounter > maxLength)
                {
                    maxLength = lengthCounter;
                }

                lengthCounter = 0;
                upperPointer = lowerPointer;
                lowerPointer++;
                visitedValues.Clear();
            }
            else
            {
                lengthCounter++;
                visitedValues.Add(character, true);
            }

            if (upperPointer < stringOfCharacters.Length - 1)
            {
                upperPointer++;
            }
        }


        return maxLength;

    }
}