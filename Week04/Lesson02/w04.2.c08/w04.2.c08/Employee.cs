public class Employee : Person
{
    public string Name;
    public double Salary;
    
    public Employee(string name, double salary): base(name)
    {
        Salary = salary;
    }
}