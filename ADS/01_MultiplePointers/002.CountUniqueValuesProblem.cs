namespace ADS.MultiplePointers;

public static class CountUniqueValuesProblem
{
    // STATEMENT OF THE PROBLEM
    // ------------------------
    // Implement a function called UniqueValues, which accepts a sorted array, and counts the unique values in the array.
    // There can be negative numbers in the array, but it will always be sorted.

    public static int? UniqueValues(int[] setOfSortedNumbers)
    {
        // NAIVE SOLUTION
        // We would need two nested loops:
        // The first loop would take one value of the array and compare it to the rest of items of the array (in a second loop) to check whether or not is unique

        // BETTER SOLUTION
        // *This works only for sorted arrays*
        // In a single loop, save the "previous value" and compare it to the "next" value, if they are different, increment the number of unique values.
        // Works only in sorted arrays because that way, same values will be grouped and it will only count a different value when entering a new "group" of equal values.

        if (setOfSortedNumbers.Length == 0)
        {
            return 0;
        }

        int numberOfUniqueValues = 1;
        int lastValue = setOfSortedNumbers[0];
        for (int i = 1; i < setOfSortedNumbers.Length; i++)
        {
            if (lastValue != setOfSortedNumbers[i])
            {
                numberOfUniqueValues++;
                lastValue = setOfSortedNumbers[i];
            }
        }

        return numberOfUniqueValues;
    }
}

