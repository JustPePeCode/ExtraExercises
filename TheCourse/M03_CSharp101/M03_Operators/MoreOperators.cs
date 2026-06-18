using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TheCourse.M03_CSharp101.Exercises.M03_Operators;

public class MoreOperators
{
    // 1. Easy: subtraction
    public int Subtract(int a, int b)
    {
        return a - b; // TODO
    }

    // 2. Easy: multiplication
    public int Multiply(int a, int b)
    {
        return a * b; // TODO
    }

    // 3. Easy: is the number odd?
    public bool IsOdd(int x)
    {
        if (x > 0)
        {
            return x % 2 == 1;
        }
        return x % 2 == -1;
        // TODO
    }

    // 4. Easy: is the number positive (strictly greater than zero)?
    public bool IsPositive(int x)
    {
        return x > 0; // TODO
    }

    // 5. Easy: is the number zero?
    public bool IsZero(int x)
    {
        return x == 0; // TODO
    }

    // 6. Medium: is the number divisible by both 3 and 5?
    public bool IsDivisibleByThreeAndFive(int x)
    {
        return x % 5 == 0 && x % 3 == 0; // TODO
    }

    // 7. Medium: is the value within the inclusive range [min, max]?
    public bool IsBetweenInclusive(int value, int min, int max)
    {
        return value >= min && value <= max; // TODO
    }

    // 8. Medium: returns true if exactly one of the two booleans is true (XOR)
    public bool ExactlyOneIsTrue(bool left, bool right)
    {
        return left ^ right; // TODO
    }

    // 9. Medium: returns the largest of two numbers
    public int Max(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        return b; // TODO
    }

    // 10. Medium: returns the smallest of two numbers
    public int Min(int a, int b)
    {
        if (a < b)
        {
            return a;
        }
        return b; // TODO
    }

    // 11. Medium: returns "Pass" if score >= 50, otherwise "Fail"
    public string GetResult(int score)
    {
        if (score >= 50)
        {
            return "Pass";
        }
        return "Fail"; // TODO
    }

    // 12. Medium: doubles the value if it is even, otherwise leaves it unchanged
    public int DoubleIfEven(int x)
    {
        if (x % 2 == 0)
        {
            return x * 2;
        }
        return x; // TODO
    }

    // 13. Medium: returns true if the year is a leap year
    // (divisible by 4, but not by 100, unless also divisible by 400)
    public bool IsLeapYear(int year)
    {
        if (year % 400 == 0)
        {
            return year % 4 == 0;
        }
        return year % 4 == 0 && year % 100 != 0; // TODO
    }

    // 14. Hard: returns the middle value of three numbers
    public decimal Median(decimal a, decimal b, decimal c)
    {
        decimal[] numbers = [a, b, c];
        Array.Sort(numbers);
        int count = numbers.Count();
        decimal median = numbers[count / 2];
        if (count % 2 == 0)
        {
            decimal medianEven = (numbers[(count / 2) - 1] + numbers[count / 2]) / 2;
            return medianEven;
        }
        return median; // TODO
    }

    // 15. Hard: returns true if all three booleans are true
    public bool AllAreTrue(bool a, bool b, bool c)
    {
        return a  && b  && c ; // TODO
    }

    // 16. Hard: returns the price after applying a percentage discount
    // (e.g. ApplyPercentageDiscount(100, 25) returns 75)
    public decimal ApplyPercentageDiscount(decimal price, decimal percentage)
    {
        return price - (price * percentage / 100); // TODO
    }

    // 17. Hard: returns true if the character is a vowel (a, e, i, o, u - case insensitive)
    public bool IsVowel(char c)
    {
        return "aeiou".Contains(char.ToLower(c));
        /*var cc=char.ToLower(c);
       return cc== 'a'||cc=='e' ||cc=='i' ||cc=='o' ||cc=='u';*/
        // TODO
    }

    // 18. Hard: returns the grade letter based on score
    // 90+: "A", 80-89: "B", 70-79: "C", 60-69: "D", below 60: "F"
    public string GetGrade(int score)
    {
        if (score >= 90)
        {
            return "A";
        }
        if (score < 90 && score >= 85)
        {
            return "B";
        }
        if (score < 85 && score >= 75)
        {
            return "C";
        }
        if (score < 75 && score >= 60)
        {
            return "D";
        }

        return "F";
        ; // TODO
    }

    // 19. Hard: returns true if the number is a power of two
    // (1, 2, 4, 8, 16, ... are powers of two)
    public bool IsPowerOfTwo(int x)
    {
        while (x >= 2 && x % 2 == 0 || x == 1)
        {
            if ( x == 1)
            {
                return true;
            }
            x /= 2; // =  x = x/2;
        }
        return false;
        ; // TODO
    }

    // 20. Hard: returns the number of true values among the three booleans
    public int CountTrue(bool a, bool b, bool c)
    {
        return new[] { a, b, c }.Count(x => x);
        /* var x = 0;
         if (a)
             x += 1;
         if (b)
             x += 1;
         if (c)
             x += 1;
 
         return x;*/
        // TODO
    }
}
