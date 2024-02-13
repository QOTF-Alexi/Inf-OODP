public class Program
{
    public static void Main()
    {
        PrintIsLeapYear(1000);
        PrintIsLeapYear(1500);
        PrintIsLeapYear(2000);
        PrintIsLeapYear(2004);
        PrintIsLeapYear(2005);
    }

    public static bool IsDivisibleBy(int var1, int var2)
    {
        if (var1 % var2 == 0)
        {
            return true;
        }
        else return false;
    }

    public static bool IsLeapYear(int year)
    {
        if ((IsDivisibleBy(year, 4) && !IsDivisibleBy(year, 100)) || IsDivisibleBy(year, 400))
        {
            return true;
        }
        else return false;
    }

    public static void PrintIsLeapYear(int year)
    {
        if (IsLeapYear(year))
        {
            Console.WriteLine(year + " is a leap year");
        }
        else
        {
            Console.WriteLine(year + " is not a leap year");
        }
    }
}