namespace TheCourse.M03_CSharp101.Exercises.M06_Methods;
public class MoreMethodsTests
{
    [Fact(Skip = "To Do")]
    public void Subtract_returns_difference_of_two_numbers()
    {
        var methods = new MoreMethods();
        var result = methods.Subtract(10, 4);
        Assert.Equal(6, result);
    }

    [Fact(Skip = "To Do")]
    public void Cube_returns_number_to_the_power_of_three()
    {
        var methods = new MoreMethods();
        var result = methods.Cube(3);
        Assert.Equal(27, result);
    }

    [Fact(Skip = "To Do")]
    public void IsPositive_with_positive_number_returns_true()
    {
        var methods = new MoreMethods();
        var result = methods.IsPositive(5);
        Assert.True(result);
    }

    [Fact(Skip = "To Do")]
    public void IsPositive_with_negative_number_returns_false()
    {
        var methods = new MoreMethods();
        var result = methods.IsPositive(-3);
        Assert.False(result);
    }

    [Fact(Skip = "To Do")]
    public void IsPositive_with_zero_returns_false()
    {
        var methods = new MoreMethods();
        var result = methods.IsPositive(0);
        Assert.False(result);
    }

    [Fact(Skip = "To Do")]
    public void Min_when_first_number_is_smaller_returns_first_number()
    {
        var methods = new MoreMethods();
        var result = methods.Min(3, 9);
        Assert.Equal(3, result);
    }

    [Fact(Skip = "To Do")]
    public void Min_when_second_number_is_smaller_returns_second_number()
    {
        var methods = new MoreMethods();
        var result = methods.Min(11, 4);
        Assert.Equal(4, result);
    }

    [Fact(Skip = "To Do")]
    public void DefaultFarewell_with_name_returns_goodbye_message()
    {
        var methods = new MoreMethods();
        var result = methods.DefaultFarewell("Bob");
        Assert.Equal("Goodbye, Bob!", result);
    }

    [Fact(Skip = "To Do")]
    public void DefaultFarewell_without_name_returns_default_goodbye_message()
    {
        var methods = new MoreMethods();
        var result = methods.DefaultFarewell();
        Assert.Equal("Goodbye, friend!", result);
    }

    [Fact(Skip = "To Do")]
    public void GetArea_returns_width_times_height()
    {
        var methods = new MoreMethods();
        var result = methods.GetArea(4, 5);
        Assert.Equal(20, result);
    }

    [Fact(Skip = "To Do")]
    public void GetPriceMessage_returns_formatted_message()
    {
        var methods = new MoreMethods();
        var result = methods.GetPriceMessage("coffee", 2);
        Assert.Equal("coffee costs 2 euros.", result);
    }

    [Fact(Skip = "To Do")]
    public void Average_returns_average_of_three_numbers()
    {
        var methods = new MoreMethods();
        var result = methods.Average(2, 3, 4);
        Assert.Equal(3.0, result);
    }

    [Fact(Skip = "To Do")]
    public void Average_can_return_a_fractional_result()
    {
        var methods = new MoreMethods();
        var result = methods.Average(1, 2, 2);
        Assert.Equal(5.0 / 3.0, result, 5);
    }

    [Fact(Skip = "To Do")]
    public void Double_without_factor_doubles_the_number()
    {
        var methods = new MoreMethods();
        var result = methods.Double(5);
        Assert.Equal(10, result);
    }

    [Fact(Skip = "To Do")]
    public void Double_with_factor_multiplies_by_the_given_factor()
    {
        var methods = new MoreMethods();
        var result = methods.Double(5, 3);
        Assert.Equal(15, result);
    }

    [Fact(Skip = "To Do")]
    public void AllEqual_when_all_numbers_are_equal_returns_true()
    {
        var methods = new MoreMethods();
        var result = methods.AllEqual(4, 4, 4);
        Assert.True(result);
    }

    [Fact(Skip = "To Do")]
    public void AllEqual_when_numbers_differ_returns_false()
    {
        var methods = new MoreMethods();
        var result = methods.AllEqual(4, 4, 5);
        Assert.False(result);
    }

    [Fact(Skip = "To Do")]
    public void SumUpTo_returns_sum_of_numbers_from_one_to_n()
    {
        var methods = new MoreMethods();
        var result = methods.SumUpTo(4);
        Assert.Equal(10, result);
    }

    [Fact(Skip = "To Do")]
    public void SumUpTo_with_one_returns_one()
    {
        var methods = new MoreMethods();
        var result = methods.SumUpTo(1);
        Assert.Equal(1, result);
    }

    [Fact(Skip = "To Do")]
    public void Factorial_returns_product_of_all_numbers_up_to_n()
    {
        var methods = new MoreMethods();
        var result = methods.Factorial(4);
        Assert.Equal(24, result);
    }

    [Fact(Skip = "To Do")]
    public void Factorial_of_zero_returns_one()
    {
        var methods = new MoreMethods();
        var result = methods.Factorial(0);
        Assert.Equal(1, result);
    }

    [Fact(Skip = "To Do")]
    public void GetInvoiceLine_without_discount_returns_full_price()
    {
        var methods = new MoreMethods();
        var result = methods.GetInvoiceLine("Book", 20);
        Assert.Equal("Book: 20 euros", result);
    }

    [Fact(Skip = "To Do")]
    public void GetInvoiceLine_with_discount_subtracts_the_discount()
    {
        var methods = new MoreMethods();
        var result = methods.GetInvoiceLine("Book", 20, 5);
        Assert.Equal("Book: 15 euros", result);
    }

    [Fact(Skip = "To Do")]
    public void IsPrime_with_prime_number_returns_true()
    {
        var methods = new MoreMethods();
        var result = methods.IsPrime(7);
        Assert.True(result);
    }

    [Fact(Skip = "To Do")]
    public void IsPrime_with_non_prime_number_returns_false()
    {
        var methods = new MoreMethods();
        var result = methods.IsPrime(8);
        Assert.False(result);
    }

    [Fact(Skip = "To Do")]
    public void IsPrime_with_one_returns_false()
    {
        var methods = new MoreMethods();
        var result = methods.IsPrime(1);
        Assert.False(result);
    }

    [Fact(Skip = "To Do")]
    public void CountDigits_returns_number_of_digits()
    {
        var methods = new MoreMethods();
        var result = methods.CountDigits(12345);
        Assert.Equal(5, result);
    }

    [Fact(Skip = "To Do")]
    public void CountDigits_of_zero_returns_one()
    {
        var methods = new MoreMethods();
        var result = methods.CountDigits(0);
        Assert.Equal(1, result);
    }
}