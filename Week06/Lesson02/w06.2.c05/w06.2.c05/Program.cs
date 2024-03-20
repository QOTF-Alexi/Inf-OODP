public class Program
{
    public static void Main(string[] args)
    {
        var jodoe = new Employee("John", "Doe", "john.doe@example.com");
        var jadoe = new Manager("Jane", "Doe", "jane.doe@example.com", "Sales");
        var bob = new SalesPerson("Bob", "Smith", "bob.smith@example.com", 100000);

        List<Employee> employees = new()
        {
            jodoe, jadoe, bob
        };

        foreach (Employee e in employees)
        {
            e.PrintEmployeeInfo();
        }
        jodoe.PrintEmployeeInfo();
        jadoe.PrintEmployeeInfo();
        bob.PrintEmployeeInfo();
    }
}