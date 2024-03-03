class DayOfWeek
{
    public int Index;
    
    public DayOfWeek(int index)
    {
        Index = index;
    }

    public static string IndexToDay(int index)
    {
        while (index > 6)
        {
            index -= 7;
        }

        while (index < 0)
        {
            index += 7;
        }

        return index switch
        {
            0 => "Monday",
            1 => "Tuesday",
            2 => "Wednesday",
            3 => "Thursday",
            4 => "Friday",
            5 => "Saturday",
            6 => "Sunday",
            _ => ""
        };
    }

    public string CurrentDay()
    {
        return IndexToDay(Index);
    }

    public void NextDay()
    {
        Index += 1;
    }

    public bool IsWeekend()
    {
        return IndexToDay(Index) == "Saturday" || IndexToDay(Index) == "Sunday";
    }
}