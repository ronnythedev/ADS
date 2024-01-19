using System;
using System.Collections.Generic;

namespace ADS.FrequencyCounterPattern;

public static class SameFrequencyProblem
{
    // STATEMENT OF THE PROBLEM
    // ------------------------
    // Given two positive integers, find out if the two numbers have the same frequency of digits.

    public static bool HaveSameFrequency(int firstNumber, int secondNumber)
    {
        // NAIVE SOLUTION
        // Might use nested loops to find each digit of the first number with each digit of the second number (in the nested loop).
        // Returns false in the moment that a number is not found in the second loop

        // BETTER SOLUTION
        // A better approach is to store the frequency of each digit in two dictionaries *using the digit as key* of the dictionary.
        // 1. The first loop will store the frequency of each digit of the first number in one dictionary.
        // 2. The second loop will store the frequency of each digit of the second number in another dictionary.
        // 3. The third loop will compare the frequencies of each digit in the two dictionaries and return accordingly.

        string firstNumberString = firstNumber.ToString();
        string secondNumberstring = secondNumber.ToString();

        if (firstNumberString.Length != secondNumberstring.Length)
        {
            return false;
        }

        var frequencyCounter1 = new Dictionary<char, int>();
        var frequencyCounter2 = new Dictionary<char, int>();

        foreach (char digit in firstNumberString)
        {
            frequencyCounter1[digit] = frequencyCounter1.GetValueOrDefault(digit, 0) + 1;
        }

        foreach (char digit in secondNumberstring)
        {
            frequencyCounter2[digit] = frequencyCounter2.GetValueOrDefault(digit, 0) + 1;
        }

        foreach (var item in frequencyCounter1)
        {
            var valueInSecondDic = frequencyCounter2.GetValueOrDefault(item.Key, 0);
            if (valueInSecondDic != item.Value)
            {
                return false;
            }
        }

        return true;
    }
}
