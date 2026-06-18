namespace TheCourse.M03_CSharp101.Exercises.M04_Conditions;

public class MoreConditions
{
    // 1. Easy: returns true if the number is negative
    public bool IsNegative(int number)
    {
        return number < 0; // TODO
    }

    // 2. Easy: returns "Yes" if the person is a senior (65 or older), otherwise "No"
    public string IsSenior(int age)
    {
        if (age >= 65)
        {
            return "Yes";
        }
        return "No"; // TODO
    }

    // 3. Easy: returns true if the password has at least 8 characters
    public bool IsPasswordLongEnough(string password)
    {
        return password.Length >= 8;
    }

    // 4. Easy: returns the day type based on a switch ("zaterdag" or "zondag" => "weekend", anything else => "weekdag")
    public string GetDayType(string day)
    {
        return day == "zaterdag" || day == "zondag" ? "weekend" : "weekdag";
        ; // TODO
    }

    // 5. Medium: returns true if a person may drive
    // (at least 18 years old AND has a license)
    public bool MayDrive(int age, bool hasLicense)
    {
        return age >= 18 && hasLicense;
        // TODO
    }

   
    
    public int TicketPrice(int age) =>
        age switch
        {
           <= 11 => 5,
            >= 65 => 7,
            _ => 10,
        };

    /*
    {
        if (age <= 11)
        {
            return 5;
        }
        if (age >= 65)
        {
            return 7;
        }
        return 10;
        ;
        */

    // 7. Medium: returns true if a number is within the range 1 to 100 (inclusive)
    public bool IsValidPercentage(int value)
    {
        return value >= 1 && value <= 100; // TODO
    }

    // 8. Medium: returns the BMI category
    // bmi < 18.5: "Ondergewicht", 18.5 to 24.9: "Normaal", 25 to 29.9: "Overgewicht", 30 or higher: "Obesitas"
    public string BmiCategory(double bmi) =>
        bmi switch
        {
            < 18.5 => "Ondergewicht",
            >= 25 and <= 29.9 => "Overgewicht",
            >= 30 => "Obesitas",
            _ => "Normaal",
        }; // TODO

    // 9. Medium: returns true if the login is successful
    // (username equals "admin" AND password equals "1234")
    public bool IsLoginSuccessful(string username, string password)
    {
        return username == "admin" && password == "1234"; // TODO
    }

    // 10. Medium: returns the season based on the month number (1-12)
    // 12, 1, 2: "Winter", 3, 4, 5: "Lente", 6, 7, 8: "Zomer", 9, 10, 11: "Herfst"
    public string GetSeason(int month) =>
        month switch
        {
            12 or 1 or 2 => "Winter",
            3 or 4 or 5 => "Lente",
            6 or 7 or 8 => "Zomer",
            _ => "Herfst",
        };

    /*string GetShippingCost(string memberType, string region) => (memberType, region) switch
    {
        ("Gold", "Domestic")     => "Free",
        ("Gold", "International") => "$5",
        ("Silver", "Domestic")    => "$3",
        ("Silver", "International") => "$10",
        ("Bronze", _)             => "$15",  // Any region
        (_, "Domestic")           => "$8",   // Any member type
        _                         => "$20",  // Default
    };
    
    Console.WriteLine(GetShippingCost("Gold", "International"));  // $5
    Console.WriteLine(GetShippingCost("Bronze", "Domestic"));      // $15*/

    // 11. Hard: returns the membership fee
    // isStudent and age < 26: 20
    // isStudent: 35
    // age >= 65: 25
    // otherwise: 50
    public int MembershipFee(int age, bool isStudent) =>
        (age, isStudent) switch
        {
            (< 26, true) => 20,
            (_, true) => 35,
            (>= 65, _) => 25,
            _ => 50,
        };

    // 12. Hard: returns true if a triangle with the given sides is valid
    // (the sum of any two sides must be greater than the third side, and all sides must be positive)
    public bool IsValidTriangle(int sideA, int sideB, int sideC)
    {
        throw new NotImplementedException(); // TODO
    }

    // 13. Hard: returns the parking fee based on hours parked
    // first hour (0 to 1, inclusive): free
    // 1 to 3 hours: 2 per hour
    // more than 3 hours: 6 + 1 per additional hour above 3
    public decimal ParkingFee(decimal hours)
    {
        throw new NotImplementedException(); // TODO
    }

    // 14. Hard: returns the password strength
    // length < 6: "Zwak"
    // length 6 to 9 without a digit: "Gemiddeld"
    // length 6 to 9 with at least one digit, or length >= 10 without digit: "Sterk"
    // length >= 10 with at least one digit: "Zeer sterk"
    public string PasswordStrength(string password, bool containsDigit)
    {
        throw new NotImplementedException(); // TODO
    }

    // 15. Hard: returns the shipping label based on combined conditions
    // isFragile and isInternational: "Fragiel - Internationaal"
    // isFragile: "Fragiel"
    // isInternational: "Internationaal"
    // otherwise: "Standaard"
    public string GetShippingLabel(bool isFragile, bool isInternational)
    {
        throw new NotImplementedException(); // TODO
    }
}
