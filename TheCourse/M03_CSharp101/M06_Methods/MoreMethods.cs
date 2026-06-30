namespace TheCourse.M03_CSharp101.Exercises.M06_Methods;

public class MoreMethods
{
    // 1. Easy: returns the difference between two numbers
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    // 2. Easy: returns the cube of a number (x * x * x)
    public int Cube(int x)
    {
        return x * x * x;
    }

    // 3. Easy: returns true if the number is positive (greater than zero)
    public bool IsPositive(int number)
    {
        return number > 0;
    }

    // 4. Easy: returns the smallest of two numbers
    public int Min(int a, int b)
    {
        if (a > b)
        {
            return b;
        }
        return a;
        ;
    }

    // 5. Medium: returns a farewell message, using a default name if none is given
    // DefaultFarewell("Bob") => "Goodbye, Bob!"
    // DefaultFarewell() => "Goodbye, friend!"
    public string DefaultFarewell(string name = "friend")
    {
        if (name == "")
        {
            return "GoodBye, friend!";
        }
        return $"Goodbye, {name}!";
        ;
    }

    // 6. Medium: returns the area of a rectangle
    public int GetArea(int width, int height)
    {
        return width * height;
    }

    // 7. Medium: returns a formatted price message
    // GetPriceMessage("coffee", 2) => "coffee costs 2 euros."
    public string GetPriceMessage(string product, int price)
    {
        return $"{product} costs {price} euros.";
    }

    // 8. Medium: returns the average of three numbers as a double
    public double Average(int a, int b, int c)
    {
        double[] numbers = { a, b, c };

        return numbers.Sum() / numbers.Count();
    }

    // 9. Medium: returns the number multiplied by a factor, with a default factor of 2
    // Double(5) => 10
    // Double(5, 3) => 15
    public int Double(int number, int factor = 2)
    {
        return number * factor;
    }

    // 10. Medium: returns true if all three numbers are equal to each other
    public bool AllEqual(int a, int b, int c)
    {
        return a == b && b == c;
    }

    // 11. Hard: returns the sum of all numbers from 1 up to and including n
    // SumUpTo(4) => 10 (1+2+3+4)
    public int SumUpTo(int n)
    {
        throw new NotImplementedException();
    }

    // 12. Hard: returns the factorial of a number
    // Factorial(4) => 24 (4*3*2*1)
    // Factorial(0) => 1
    public int Factorial(int n)
    {
        throw new NotImplementedException();
    }

    // 13. Hard: returns a formatted invoice line, with an optional discount
    // GetInvoiceLine("Book", 20) => "Book: 20 euros"
    // GetInvoiceLine("Book", 20, 5) => "Book: 15 euros"
    public string GetInvoiceLine(string product, int price, int discount = 0)
    {
        throw new NotImplementedException();
    }

    // 14. Hard: returns true if the number is prime
    // (a prime number is greater than 1 and has no divisors other than 1 and itself)
    public bool IsPrime(int number)
    {
        throw new NotImplementedException();
    }

    // 15. Hard: returns the number of digits in a positive integer
    // CountDigits(12345) => 5
    // CountDigits(0) => 1
    public int CountDigits(int number)
    {
        throw new NotImplementedException();
    }
}
