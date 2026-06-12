namespace TheCourse.M03_CSharp101.Exercises.M08_Collections;

public class MoreCollectionsTests
{
    [Fact(Skip = "To Do")]
    public void CountItems_returns_number_of_elements_in_list()
    {
        var c = new MoreCollections();
        var result = c.CountItems(new List<string> { "a", "b", "c" });
        Assert.Equal(3, result);
    }

    [Fact(Skip = "To Do")]
    public void GetFirstItem_returns_first_element_of_list()
    {
        var c = new MoreCollections();
        var result = c.GetFirstItem(new List<string> { "Alice", "Bob", "Charlie" });
        Assert.Equal("Alice", result);
    }

    [Fact(Skip = "To Do")]
    public void MaxValue_returns_largest_number_in_array()
    {
        var c = new MoreCollections();
        var result = c.MaxValue(new[] { 3, 7, 2, 9, 4 });
        Assert.Equal(9, result);
    }

    [Fact(Skip = "To Do")]
    public void MinValue_returns_smallest_number_in_array()
    {
        var c = new MoreCollections();
        var result = c.MinValue(new[] { 3, 7, 2, 9, 4 });
        Assert.Equal(2, result);
    }

    [Theory(Skip = "To Do")]
    [InlineData(3, true)]
    [InlineData(5, false)]
    public void ContainsValue_checks_if_list_contains_given_value(int value, bool expected)
    {
        var c = new MoreCollections();
        var result = c.ContainsValue(new List<int> { 1, 2, 3, 4 }, value);
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void ToUpperCaseAll_converts_all_words_to_uppercase()
    {
        var c = new MoreCollections();
        var result = c.ToUpperCaseAll(new List<string> { "cat", "dog" });
        Assert.Equal(new List<string> { "CAT", "DOG" }, result);
    }

    [Theory(Skip = "To Do")]
    [InlineData(new[] { 1, 2, 3 }, true)]
    [InlineData(new[] { 1, -2, 3 }, false)]
    public void AllPositive_checks_if_all_numbers_are_positive(int[] numbers, bool expected)
    {
        var c = new MoreCollections();
        var result = c.AllPositive(numbers);
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void RemoveDuplicates_returns_list_with_unique_values_only()
    {
        var c = new MoreCollections();
        var result = c.RemoveDuplicates(new List<int> { 1, 2, 2, 3, 1, 4 });
        Assert.Equal(new List<int> { 1, 2, 3, 4 }, result);
    }

    [Fact(Skip = "To Do")]
    public void SortDescending_returns_numbers_sorted_from_high_to_low()
    {
        var c = new MoreCollections();
        var result = c.SortDescending(new List<int> { 3, 1, 4, 1, 5 });
        Assert.Equal(new List<int> { 5, 4, 3, 1, 1 }, result);
    }

    [Fact(Skip = "To Do")]
    public void AverageOfList_returns_correct_average_value()
    {
        var c = new MoreCollections();
        var result = c.AverageOfList(new List<int> { 2, 4, 6, 8 });
        Assert.Equal(5, result);
    }

    [Fact(Skip = "To Do")]
    public void GetNamesStartingWith_returns_only_names_starting_with_given_letter()
    {
        var c = new MoreCollections();
        var result = c.GetNamesStartingWith(new List<string> { "Alice", "Anna", "Bob" }, 'A');
        Assert.Equal(new List<string> { "Alice", "Anna" }, result);
    }

    [Fact(Skip = "To Do")]
    public void CountWordOccurrences_counts_how_often_each_word_appears()
    {
        var c = new MoreCollections();
        var result = c.CountWordOccurrences(new[] { "a", "b", "a", "c", "a" });
        Assert.Equal(3, result["a"]);
    }

    [Theory(Skip = "To Do")]
    [InlineData("name", "Alice")]
    [InlineData("missing", "Unknown")]
    public void TryGetValueOrDefault_returns_value_or_unknown(string key, string expected)
    {
        var c = new MoreCollections();
        var data = new Dictionary<string, string> { ["name"] = "Alice" };
        var result = c.TryGetValueOrDefault(data, key);
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void GetEvenIndexedValues_returns_values_at_even_indexes()
    {
        var c = new MoreCollections();
        var result = c.GetEvenIndexedValues(new List<int> { 10, 20, 30, 40, 50 });
        Assert.Equal(new List<int> { 10, 30, 50 }, result);
    }

    [Fact(Skip = "To Do")]
    public void MergeAndSortUnique_combines_two_lists_without_duplicates_and_sorts()
    {
        var c = new MoreCollections();
        var result = c.MergeAndSortUnique(new List<string> { "banana", "apple" }, new List<string> { "apple", "cherry" });
        Assert.Equal(new List<string> { "apple", "banana", "cherry" }, result);
    }

    [Fact(Skip = "To Do")]
    public void FindCommonItems_returns_items_present_in_both_lists()
    {
        var c = new MoreCollections();
        var result = c.FindCommonItems(new List<string> { "a", "b", "c" }, new List<string> { "b", "c", "d" });
        Assert.Equal(new List<string> { "b", "c" }, result);
    }

    [Fact(Skip = "To Do")]
    public void GroupNumbersByParity_groups_numbers_into_even_and_odd_lists()
    {
        var c = new MoreCollections();
        var result = c.GroupNumbersByParity(new[] { 1, 2, 3, 4, 5, 6 });
        Assert.Equal(new List<int> { 2, 4, 6 }, result["Even"]);
        Assert.Equal(new List<int> { 1, 3, 5 }, result["Odd"]);
    }

    [Fact(Skip = "To Do")]
    public void CountWordsLongerThanAverage_returns_correct_count()
    {
        var c = new MoreCollections();
        var result = c.CountWordsLongerThanAverage(new List<string> { "a", "bb", "ccc", "dddd" });
        Assert.Equal(2, result);
    }

    [Fact(Skip = "To Do")]
    public void RankNamesByScore_returns_names_sorted_by_score_descending()
    {
        var c = new MoreCollections();
        var input = new Dictionary<string, int> { ["Alice"] = 50, ["Bob"] = 80, ["Charlie"] = 65 };
        var result = c.RankNamesByScore(input);
        Assert.Equal(new List<string> { "Bob", "Charlie", "Alice" }, result);
    }

    [Fact(Skip = "To Do")]
    public void FindMostFrequentNumber_returns_the_number_with_highest_occurrence()
    {
        var c = new MoreCollections();
        var result = c.FindMostFrequentNumber(new[] { 1, 2, 2, 3, 3, 1, 1 });
        Assert.Equal(1, result);
    }
}