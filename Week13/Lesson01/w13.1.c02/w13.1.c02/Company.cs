public class Company
{
    private List<Employee> _employees { get; } = new();
    public void HireEmployee(Employee emp) => _employees.Add(emp);

    // FilterEmployees goes here
    public List<Employee> FilterEmployees(Func<Employee, bool> filter)
    {
        var filteredie = _employees.Where(e => filter(e));
        var filteredList = new List<Employee>();
        foreach (Employee emp in filteredie)
        {
            filteredList.Add(emp);
        }

        return filteredList;
    }
}