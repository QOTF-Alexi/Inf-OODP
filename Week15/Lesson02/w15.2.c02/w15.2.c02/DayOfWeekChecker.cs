public enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public static class DayOfWeekChecker
{
    public static void CheckDayOfWeek(string input)
    {
        if (!Enum.TryParse(input, out DayOfWeek day))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        // Create a switch here that, depending on the user input, prints:
        //  - It's a weekday.
        //  - It's the weekend.
        //  - Invalid day of the week
        switch (day)
        {
            case DayOfWeek.Monday:
            case DayOfWeek.Tuesday:
            case DayOfWeek.Wednesday:
            case DayOfWeek.Thursday:
            case DayOfWeek.Friday:
                Console.WriteLine("It's a weekday.");
                break;
            case DayOfWeek.Saturday:
            case DayOfWeek.Sunday:
                Console.WriteLine("It's the weekend.");
                break;
            default:
                Console.WriteLine("Invalid day of the week.");
                break;
        }

    }
}