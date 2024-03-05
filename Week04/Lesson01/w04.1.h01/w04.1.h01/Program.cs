class Program
{
    public static void Main()
    {
        var company = new Company();
        var people = new List<Employee>()
        {
            new Employee(1000, 10),
            new Employee(1000, 20),
            new Employee(1000, 30),
            new Employee(1000, 40),
        };
        foreach (var person in people)
        {
            company.Hire(person);
        }

        company.PayMonthlySalary();
        foreach (var employee in company.Employees)
        {
            Console.WriteLine($"Employee has earned {employee.SalaryEarned}");
        }
    }
}