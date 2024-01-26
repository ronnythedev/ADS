using System.Collections.Generic;

namespace ADS.MultiplePointers;

public static class SubsequenceProblem
{
    // STATEMENT OF THE PROBLEM
    // ------------------------
    // Write a function called IsSubsequence which takes in two strings and checks whether the 
    // characters in the first string forma subsequence of the characters in the second string,
    // not matter if there are characters in between in the second string.

    public static bool IsSubsequence(string firstString, string secondString)
    {
        // NAIVE SOLUTION


        // BETTER SOLUTION
        // Loop over the second string
        // Keep a counter that increases only when the character in the second string is found in the first string in [counter] position
        // Compare the lenght of the first string with the counter

        if (firstString.Length == 0 || secondString.Length == 0)
        {
            return false;
        }

        var counter = 0;
        foreach (char character in secondString)
        {
            var character2 = firstString[counter];
            if (character == character2)
            {
                counter += 1;
            }

            if (counter == firstString.Length)
            {
                return true;
            }
        }

        return false;
    }
}

