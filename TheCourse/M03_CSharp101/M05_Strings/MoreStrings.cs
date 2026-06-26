using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using Xunit.Sdk;

namespace TheCourse.M03_CSharp101.Exercises.M05_Strings;

public class MoreStrings
{
    // 1. Easy: returns the length of the string
    public int GetLength(string input)
    {
        return input.Length; // TODO
    }

    // 2. Easy: returns the string in lowercase
    public string ToLowerCase(string input)
    {
        return input.ToLower(); // TODO
    }

    // 3. Easy: returns true if the string is empty
    public bool IsEmpty(string input)
    {
        return input.Length == 0; // TODO
    }

    // 4. Easy: returns the string with leading and trailing whitespace removed
    public string TrimSpaces(string input)
    {
        return input.Trim(' '); // TODO
    }

    // 5. Medium: returns true if the string starts with the given prefix
    public bool StartsWithPrefix(string input, string prefix)
    {
        return input.StartsWith(prefix); // TODO
    }

    // 6. Medium: returns true if the string ends with the given suffix
    public bool EndsWithSuffix(string input, string suffix)
    {
        return input.EndsWith(suffix); // TODO
    }

    // 7. Medium: returns the string with the first letter capitalized
    // (e.g. "hello" becomes "Hello")
    public string Capitalize(string input)
    {
        if (input == "")
        {
            return "";
        }
        return char.ToUpper(input[0]) + input.Substring(1); // TODO
    }

    // 8. Medium: returns the string repeated a given number of times
    // (e.g. Repeat("ab", 3) returns "ababab")
    public string Repeat(string input, int times)
    {
        var result = "";
        for (int i = 0; i < times; i++)
        {
            result += input;
        }
        return result;
    }

    // 9. Medium: returns the string with all spaces removed
    public string RemoveSpaces(string input)
    {
        return input.Replace(" ", "");
        // TODO
    }

    // 10. Medium: returns the index of the first occurrence of the keyword,
    // or -1 if it is not found
    public int FindKeyword(string sentence, string keyword)
    {
        return sentence.IndexOf(keyword); // TODO
    }

    // 11. Medium: returns the string reversed
    // (e.g. "hello" becomes "olleh")
    public string Reverse(string input)
    {
        return string.Concat(input.Reverse()); // TODO
    }

    // 12. Hard: returns true if the string is a palindrome (reads the same forwards and backwards)
    // case insensitive, e.g. "Level" and "level" are both palindromes
    public bool IsPalindrome(string input)
    {
        return input.ToLower() == string.Concat(input.ToLower().Reverse()); // TODO
    }

    // 13. Hard: returns the number of times the given character appears in the string
    public int CountOccurrences(string input, char character)
    {
        var count = 0;
        foreach (var c in input)
        {
            if (character == c)
            {
                count += 1;
            }
        }
        return count;
    }

    // 14. Hard: returns each word capitalized, separated by single spaces
    // (e.g. "the quick   fox" becomes "The Quick Fox")
    public string TitleCase(string sentence)
    {
        var words = sentence.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Count(); i++)
        {
            words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
        }
        return string.Join(" ", words);
    }

    // 15. Hard: returns the initials of each word in uppercase, without separators
    // (e.g. "Lukas Motte" becomes "LM")
    public string GetInitials(string fullName)
    {
        throw new NotImplementedException(); // TODO
    }

    // 16. Hard: returns true if the string contains only digits (and is not empty)
    public bool IsNumeric(string input)
    {
        throw new NotImplementedException(); // TODO
    }

    // 17. Hard: masks all but the last 4 characters of a string with '*'
    // (e.g. "1234567812345678" becomes "************5678")
    // if the string has 4 or fewer characters, return it unchanged
    public string MaskExceptLast4(string input)
    {
        throw new NotImplementedException(); // TODO
    }

    // 18. Hard: returns the longest word in the sentence
    // (if there are multiple words with the same maximum length, return the first one)
    public string GetLongestWord(string sentence)
    {
        throw new NotImplementedException(); // TODO
    }
}
