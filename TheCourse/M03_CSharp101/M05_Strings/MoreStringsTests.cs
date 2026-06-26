namespace TheCourse.M03_CSharp101.Exercises.M05_Strings;

public class MoreStringsTests
{
    [Theory]
    [InlineData("hello", 5)]
    [InlineData("", 0)]
    [InlineData("a", 1)]
    public void GetLength_returns_the_number_of_characters(string input, int expected)
    {
        Assert.Equal(expected, new MoreStrings().GetLength(input));
    }

    [Theory]
    [InlineData("HELLO", "hello")]
    [InlineData("Hello World", "hello world")]
    [InlineData("already low", "already low")]
    public void ToLowerCase_converts_to_lowercase(string input, string expected)
    {
        Assert.Equal(expected, new MoreStrings().ToLowerCase(input));
    }

    [Theory]
    [InlineData("", true)]
    [InlineData("a", false)]
    [InlineData("hello", false)]
    public void IsEmpty_returns_true_only_for_empty_strings(string input, bool expected)
    {
        Assert.Equal(expected, new MoreStrings().IsEmpty(input));
    }

    [Theory]
    [InlineData("  hello  ", "hello")]
    [InlineData("hello", "hello")]
    [InlineData("   ", "")]
    public void TrimSpaces_removes_leading_and_trailing_whitespace(string input, string expected)
    {
        Assert.Equal(expected, new MoreStrings().TrimSpaces(input));
    }

    [Theory]
    [InlineData("unbelievable", "un", true)]
    [InlineData("unbelievable", "believ", false)]
    [InlineData("Hello", "hello", false)]
    public void StartsWithPrefix_checks_the_beginning_of_the_string(string input, string prefix, bool expected)
    {
        Assert.Equal(expected, new MoreStrings().StartsWithPrefix(input, prefix));
    }

    [Theory]
    [InlineData("unbelievable", "able", true)]
    [InlineData("unbelievable", "un", false)]
    [InlineData("Hello", "hello", false)]
    public void EndsWithSuffix_checks_the_end_of_the_string(string input, string suffix, bool expected)
    {
        Assert.Equal(expected, new MoreStrings().EndsWithSuffix(input, suffix));
    }

    [Theory]
    [InlineData("hello", "Hello")]
    [InlineData("Hello", "Hello")]
    [InlineData("a", "A")]
    [InlineData("", "")]
    public void Capitalize_uppercases_the_first_letter(string input, string expected)
    {
        Assert.Equal(expected, new MoreStrings().Capitalize(input));
    }

    [Theory]
    [InlineData("ab", 3, "ababab")]
    [InlineData("x", 4, "xxxx")]
    [InlineData("hi", 0, "")]
    [InlineData("hi", 1, "hi")]
    public void Repeat_repeats_the_string_the_given_number_of_times(string input, int times, string expected)
    {
        Assert.Equal(expected, new MoreStrings().Repeat(input, times));
    }

    [Theory]
    [InlineData("hello world", "helloworld")]
    [InlineData("a b c", "abc")]
    [InlineData("nospaces", "nospaces")]
    public void RemoveSpaces_removes_all_spaces(string input, string expected)
    {
        Assert.Equal(expected, new MoreStrings().RemoveSpaces(input));
    }

    [Theory]
    [InlineData("the quick brown fox", "quick", 4)]
    [InlineData("jumped over", "lazy", -1)]
    [InlineData("hello world", "hello", 0)]
    public void FindKeyword_returns_the_index_of_the_keyword_or_minus_one(string sentence, string keyword, int expected)
    {
        Assert.Equal(expected, new MoreStrings().FindKeyword(sentence, keyword));
    }

    [Theory]
    [InlineData("hello", "olleh")]
    [InlineData("ab", "ba")]
    [InlineData("a", "a")]
    [InlineData("", "")]
    public void Reverse_reverses_the_string(string input, string expected)
    {
        Assert.Equal(expected, new MoreStrings().Reverse(input));
    }

    [Theory]
    [InlineData("level", true)]
    [InlineData("Level", true)]
    [InlineData("hello", false)]
    [InlineData("a", true)]
    [InlineData("", true)]
    public void IsPalindrome_checks_if_the_string_reads_the_same_backwards(string input, bool expected)
    {
        Assert.Equal(expected, new MoreStrings().IsPalindrome(input));
    }

    [Theory]
    [InlineData("banana", 'a', 3)]
    [InlineData("hello", 'l', 2)]
    [InlineData("hello", 'z', 0)]
    public void CountOccurrences_counts_how_often_a_character_appears(string input, char character, int expected)
    {
        Assert.Equal(expected, new MoreStrings().CountOccurrences(input, character));
    }

    [Theory]
    [InlineData("the quick brown fox", "The Quick Brown Fox")]
    [InlineData("the quick   fox", "The Quick Fox")]
    [InlineData("hello", "Hello")]
    public void TitleCase_capitalizes_each_word(string sentence, string expected)
    {
        Assert.Equal(expected, new MoreStrings().TitleCase(sentence));
    }

    [Theory(Skip = "To Do")]
    [InlineData("Lukas Motte", "LM")]
    [InlineData("I Love CSharp", "ILC")]
    [InlineData("Mark", "M")]
    public void GetInitials_returns_the_uppercase_initials(string fullName, string expected)
    {
        Assert.Equal(expected, new MoreStrings().GetInitials(fullName));
    }

    [Theory(Skip = "To Do")]
    [InlineData("12345", true)]
    [InlineData("123a5", false)]
    [InlineData("", false)]
    [InlineData("0", true)]
    public void IsNumeric_checks_if_the_string_contains_only_digits(string input, bool expected)
    {
        Assert.Equal(expected, new MoreStrings().IsNumeric(input));
    }

    [Theory(Skip = "To Do")]
    [InlineData("1234567812345678", "************5678")]
    [InlineData("12345", "*2345")]
    [InlineData("1234", "1234")]
    [InlineData("12", "12")]
    public void MaskExceptLast4_masks_all_but_the_last_four_characters(string input, string expected)
    {
        Assert.Equal(expected, new MoreStrings().MaskExceptLast4(input));
    }

    [Theory(Skip = "To Do")]
    [InlineData("I love CSharp programming", "programming")]
    [InlineData("a bb ccc dd", "ccc")]
    [InlineData("cat dog cow", "cat")]
    public void GetLongestWord_returns_the_first_longest_word(string sentence, string expected)
    {
        Assert.Equal(expected, new MoreStrings().GetLongestWord(sentence));
    }
}