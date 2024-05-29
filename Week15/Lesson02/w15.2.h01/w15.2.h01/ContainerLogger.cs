public static class ContainerLogger
{
    public static Dictionary<string, Container> containerLog = new();

    public static void Log(Container container)
    {
        if (!containerLog.ContainsKey(container.Code))
        {
            containerLog.Add(container.Code, container);
        }
        else
        {
            containerLog.Remove(container.Code);
            containerLog.Add(container.Code, container);
        }
    }

    public static void Print()
    {
        foreach (var entry in containerLog)
        {
            Console.WriteLine(entry.Value);
        }
    }

    public static void GetAverageWeightDeviation(ContainerStatus status)
    {
        var filteredContainers =
            (from c in containerLog
            where c.Value.Status == status
            select c).ToList();
        // calculate average deviation here.
        var containerCount = filteredContainers.Count;
        int deviations = 0;
        foreach (var container in filteredContainers)
        {
            deviations += (int)(container.Value.Weight - container.Value.ActualWeight);
        }

        var avgDev = deviations / containerCount;
        Console.WriteLine($"Average Deviation from containers with status '{status}': {avgDev}");
    }

    public static void GetDistinctCategories(ContainerStatus status)
    {
        /*This method retrieves and prints the distinct Categories from containers with the specified status using LINQ.
         Filter the containerLog dictionary based on the specified ContainerStatus.
         Use LINQ methods to select all categories from the filtered containers using SelectMany() and Distinct() to retrieve the unique categories.*/
        
        // Filter containers based on the specified status
        var filteredContainers = containerLog.Values
            .Where(container => container.Status == status);


        // Retrieve distinct categories using SelectMany() and Distinct()
        var distinctCategories = filteredContainers
            .SelectMany(container => container.Categories)
            .Distinct().ToArray();
        
        Console.Write($"Distinct categories from containers with status '{status}': [");
        foreach (var cat in distinctCategories)
        {
            Console.Write($", {cat}");
        }

        Console.Write("]");
    }
}