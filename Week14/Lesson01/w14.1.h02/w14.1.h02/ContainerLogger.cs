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
}