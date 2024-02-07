public class Program
{
    public static void Main()
    {
        List<string> todos = new List<string>();
        PrintOverview(todos);
        todos.Add("Mow lawn");
        todos.Add("Pay taxes");
        PrintOverview(todos);
        todos.Remove("Mow lawn");
        todos.Add("Shopping");
        PrintOverview(todos);
    }

    static void PrintOverview(List<string> lst)
    {
        Console.WriteLine("Amount of tasks: " + lst.Count);
        foreach (var t in lst)
        {
            Console.WriteLine(t);
        }
    }
}