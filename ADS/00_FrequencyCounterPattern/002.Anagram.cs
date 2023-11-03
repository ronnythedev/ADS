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
        // A "brute-force" solution might be to use nested loops to compare each letter of the first word with each letter of the second word.

        // A better approach is to store in two dictionaries the frequency of each letter using the letter as key of the dictionary.

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
