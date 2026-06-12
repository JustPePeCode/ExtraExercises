namespace TheCourse.M03_CSharp101.Exercises.M08_Collections;

public class MoreCollections
{
    // 1. Easy: returns the number of items in the list
    public int CountItems(List<string> items)
    {
        throw new NotImplementedException(); // TODO
    }

    // 2. Easy: returns the first item of the list
    public string GetFirstItem(List<string> items)
    {
        throw new NotImplementedException(); // TODO
    }

    // 3. Easy: returns the largest number in the array
    public int MaxValue(int[] numbers)
    {
        throw new NotImplementedException(); // TODO
    }

    // 4. Easy: returns the smallest number in the array
    public int MinValue(int[] numbers)
    {
        throw new NotImplementedException(); // TODO
    }

    // 5. Easy: returns true if the list contains the given value
    public bool ContainsValue(List<int> numbers, int value)
    {
        throw new NotImplementedException(); // TODO
    }

    // 6. Medium: returns a new list with all words converted to uppercase
    public List<string> ToUpperCaseAll(List<string> words)
    {
        throw new NotImplementedException(); // TODO
    }

    // 7. Medium: returns true if all numbers in the array are positive
    public bool AllPositive(int[] numbers)
    {
        throw new NotImplementedException(); // TODO
    }

    // 8. Medium: returns a new list with duplicate values removed
    public List<int> RemoveDuplicates(List<int> numbers)
    {
        throw new NotImplementedException(); // TODO
    }

    // 9. Medium: returns the list sorted from high to low
    public List<int> SortDescending(List<int> numbers)
    {
        throw new NotImplementedException(); // TODO
    }

    // 10. Medium: returns the average of the numbers in the list
    public double AverageOfList(List<int> numbers)
    {
        throw new NotImplementedException(); // TODO
    }

    // 11. Medium: returns only the names that start with the given letter (case insensitive)
    public List<string> GetNamesStartingWith(List<string> names, char letter)
    {
        throw new NotImplementedException(); // TODO
    }

    // 12. Medium: returns a dictionary counting how often each word appears
    public Dictionary<string, int> CountWordOccurrences(string[] words)
    {
        throw new NotImplementedException(); // TODO
    }

    // 13. Medium: returns the value at the given key, or "Unknown" if the key does not exist
    public string TryGetValueOrDefault(Dictionary<string, string> data, string key)
    {
        throw new NotImplementedException(); // TODO
    }

    // 14. Hard: returns only the values at even indexes (0, 2, 4, ...)
    public List<int> GetEvenIndexedValues(List<int> numbers)
    {
        throw new NotImplementedException(); // TODO
    }

    // 15. Hard: combines two lists, removes duplicates and returns them sorted alphabetically
    public List<string> MergeAndSortUnique(List<string> list1, List<string> list2)
    {
        throw new NotImplementedException(); // TODO
    }

    // 16. Hard: returns the items that appear in both lists
    public List<string> FindCommonItems(List<string> list1, List<string> list2)
    {
        throw new NotImplementedException(); // TODO
    }

    // 17. Hard: splits the numbers into two lists, one with even and one with odd numbers
    // (e.g. returns a dictionary with keys "Even" and "Odd")
    public Dictionary<string, List<int>> GroupNumbersByParity(int[] numbers)
    {
        throw new NotImplementedException(); // TODO
    }

    // 18. Hard: returns how many words are longer than the average word length
    public int CountWordsLongerThanAverage(List<string> words)
    {
        throw new NotImplementedException(); // TODO
    }

    // 19. Hard: returns the names sorted by score, from highest to lowest
    // (e.g. { "Alice": 50, "Bob": 80, "Charlie": 65 } -> ["Bob", "Charlie", "Alice"])
    public List<string> RankNamesByScore(Dictionary<string, int> scores)
    {
        throw new NotImplementedException(); // TODO
    }

    // 20. Hard: returns the most frequently occurring number in the array
    // (if there is a tie, return the smallest of the most frequent numbers)
    public int FindMostFrequentNumber(int[] numbers)
    {
        throw new NotImplementedException(); // TODO
    }
}