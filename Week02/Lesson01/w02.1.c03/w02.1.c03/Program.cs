public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a first name");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter a last name");
        string lastName = Console.ReadLine();
        DisplayName(firstName, lastName);
    }
    
    static string Name(string firstName, string lastName) => firstName + " " + lastName;

    static void DisplayName(string firstName, string lastName) => Console.WriteLine(Name(firstName, lastName));
}