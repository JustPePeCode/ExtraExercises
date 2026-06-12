namespace TheCourse.M03_CSharp101.Exercises.M09_ControlFlow;

public class MoreControlFlowTests
{
    [Fact(Skip = "To Do")]
    public void GetMultiplesOfThreeUpTo_returns_multiples_of_three()
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.GetMultiplesOfThreeUpTo(10);
        Assert.Equal([3, 6, 9], result);
    }

    [Fact(Skip = "To Do")]
    public void GetSquaresUpTo_returns_squares_of_numbers_from_1_to_limit()
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.GetSquaresUpTo(5);
        Assert.Equal([1, 4, 9, 16, 25], result);
    }

    [Theory(Skip = "To Do")]
    [InlineData(3, true)]
    [InlineData(7, false)]
    public void Contains_checks_if_array_contains_value(int value, bool expected)
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.Contains([1, 2, 3, 4], value);
        Assert.Equal(expected, result);
    }

    [Theory(Skip = "To Do")]
    [InlineData("hello", 2)]
    [InlineData("sky", 0)]
    [InlineData("orange", 3)]
    public void CountVowels_returns_correct_vowel_count(string word, int expected)
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.CountVowels(word);
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void ReverseEachWord_reverses_every_word_in_the_array()
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.ReverseEachWord(["cat", "dog"]);
        Assert.Equal(["tac", "god"], result);
    }

    [Fact(Skip = "To Do")]
    public void SumWhileIncreasing_stops_at_first_non_increasing_number()
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.SumWhileIncreasing([1, 3, 5, 2, 10]);
        Assert.Equal(9, result);
    }

    [Fact(Skip = "To Do")]
    public void FindFirstWordLongerThan_returns_first_matching_word()
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.FindFirstWordLongerThan(["sun", "cloud", "rainbow"], 4);
        Assert.Equal("cloud", result);
    }

    [Fact(Skip = "To Do")]
    public void FindFirstWordLongerThan_returns_empty_string_when_no_word_matches()
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.FindFirstWordLongerThan(["sun", "sky"], 5);
        Assert.Equal(string.Empty, result);
    }

    [Theory(Skip = "To Do")]
    [InlineData(3, 2)]
    [InlineData(9, -1)]
    public void FindIndex_returns_index_of_value_or_minus_one(int value, int expected)
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.FindIndex([5, 1, 3, 8], value);
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void SkipFirst_skips_the_given_number_of_elements()
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.SkipFirst([1, 2, 3, 4, 5], 2);
        Assert.Equal([3, 4, 5], result);
    }

    [Fact(Skip = "To Do")]
    public void TakeFirst_returns_the_first_n_elements()
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.TakeFirst([1, 2, 3, 4, 5], 3);
        Assert.Equal([1, 2, 3], result);
    }

    [Theory(Skip = "To Do")]
    [InlineData(0, true)]
    [InlineData(3, false)]
    public void AllGreaterThan_checks_if_all_numbers_exceed_threshold(int threshold, bool expected)
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.AllGreaterThan([1, 2, 3, 4], threshold);
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void RunningTotal_returns_cumulative_sums()
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.RunningTotal([1, 2, 3, 4]);
        Assert.Equal([1, 3, 6, 10], result);
    }

    [Fact(Skip = "To Do")]
    public void Fibonacci_returns_correct_sequence()
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.Fibonacci(6);
        Assert.Equal([0, 1, 1, 2, 3, 5], result);
    }

    [Fact(Skip = "To Do")]
    public void PairUp_groups_numbers_into_pairs_and_skips_last_if_odd()
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.PairUp([1, 2, 3, 4, 5]);
        Assert.Equal([(1, 2), (3, 4)], result);
    }

    [Theory(Skip = "To Do")]
    [InlineData(new[] { 1, 2, 3, 4 }, true)]
    [InlineData(new[] { 3, 1, 2 }, false)]
    public void IsSorted_checks_if_array_is_ascending(int[] numbers, bool expected)
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.IsSorted(numbers);
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void FindLongestWord_returns_the_longest_word()
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.FindLongestWord(["cat", "elephant", "dog"]);
        Assert.Equal("elephant", result);
    }

    [Fact(Skip = "To Do")]
    public void FindLongestWord_returns_empty_string_when_array_is_empty()
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.FindLongestWord([]);
        Assert.Equal(string.Empty, result);
    }

    [Fact(Skip = "To Do")]
    public void FizzBuzz_returns_correct_sequence_up_to_limit()
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.FizzBuzz(15);
        Assert.Equal(["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"], result);
    }

    [Theory(Skip = "To Do")]
    [InlineData(7, true)]
    [InlineData(8, false)]
    [InlineData(1, false)]
    [InlineData(2, true)]
    public void IsPrime_checks_if_number_is_prime(int number, bool expected)
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.IsPrime(number);
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void GetPrimesUpTo_returns_all_primes_up_to_limit()
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.GetPrimesUpTo(20);
        Assert.Equal([2, 3, 5, 7, 11, 13, 17, 19], result);
    }

    [Fact(Skip = "To Do")]
    public void GetDigits_returns_digits_of_a_number_as_array()
    {
        var controlFlow = new MoreControlFlow();
        var result = controlFlow.GetDigits(1234);
        Assert.Equal([1, 2, 3, 4], result);
    }
}