using Newtonsoft.Json;

public static class HistoricalEventSearch
{
    public static List<HistoricalEvent> ReadEvents(string dataset)
    {
        StreamReader reader = new StreamReader(dataset);
        string jsonString = reader.ReadToEnd();
        reader.Close();
        return JsonConvert.DeserializeObject<List<HistoricalEvent>>(jsonString)!;
    }

    public static List<HistoricalEvent> SearchInDescription(List<HistoricalEvent> list, string search)
    {
        return list.Where(e => e.Description.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public static List<HistoricalEvent> SearchBetweenYears(List<HistoricalEvent> list, int fromYear, int toYear)
    {
        return list.Where(e => e.Year >= fromYear && e.Year <= toYear).ToList();
    }

    public static int AverageEventYear(List<HistoricalEvent> list)
    {
        if (list == null || list.Count == 0)
            return 0; // Return 0 if the list is empty

        // Calculate the sum of years
        int totalYears = list.Sum(e => e.Year);

        // Calculate the average year
        int averageYear = totalYears / list.Count;

        return averageYear;
    }
}