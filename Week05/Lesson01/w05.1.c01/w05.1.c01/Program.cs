class Program
{
    public static void Main()
    {
        Person john = new("John Doe");
        Student jane = new("Jane Doe");
        List<Person> peoples = new()
        {
            john,
            jane
        };
        foreach (Person p in peoples)
        {
            Console.WriteLine(p.Introduce());
            if (p is Student converted)
            {
                Console.WriteLine(converted.Status());
            }
        }
    }
}