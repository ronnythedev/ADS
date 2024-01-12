using System;
using System.Collections.Generic;

namespace ADS.FrequencyCounterPattern;

public static class AnagramProblem
{
    // STATEMENT OF THE PROBLEM
    // ------------------------
    // Given two strings, write a function to determine if the second string is an anagram of the first.
    // An anagram is a word, phrase, or name formed by rearranging the letters of another, such "cinema", formed from "iceman"

    public static bool IsValidAnagram(string firstWord, string secondWord)
    {
        // "BRUTE FORCE" SOLUTION
        // It might be to use nested loops to compare each letter of the first word with each letter of the second word.

        // BETTER SOLUTION
        // A better approach is to store the frequency in two dictionaries of each letter *using the letter as key* of the dictionary.
        // 1. The first loop will store the frequency of each letter of the first word in one dictionary.
        // 2. The second loop will store the frequency of each letter of the second word in another dictionary.
        // 3. The third loop will compare the frequencies of each letter in the two dictionaries and return accordingly.

        if (firstWord.Length != secondWord.Length)
        {
            return false;
        }

        var frequencyCounter1 = new Dictionary<char, int>();
        var frequencyCounter2 = new Dictionary<char, int>();

        // store frequency of each letter of "firstWord" in one dictionary
        foreach (char letter in firstWord)
        {
            frequencyCounter1[letter] = frequencyCounter1.GetValueOrDefault(letter, 0) + 1;
        }

        // store frequency of each letter of "secondWord" in another dictionary
        foreach (char letter in secondWord)
        {
            frequencyCounter2[letter] = frequencyCounter2.GetValueOrDefault(letter, 0) + 1;
        }

        // loop over the first dictionary
        foreach (var key in frequencyCounter1.Keys)
        {
            // if second dictonary doesn't contain the key (letter) return false immediately
            if (!frequencyCounter2.ContainsKey(key))
            {
                return false;
            }

            // if the frequency stored in each dictionary in the given key (letter) is different, return false immediately
            if (frequencyCounter1[key] != frequencyCounter2[key])
            {
                return false;
            }
        }

        return true;
    }
}
