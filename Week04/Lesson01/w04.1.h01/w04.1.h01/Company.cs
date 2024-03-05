class Company
{
    public List<Employee> Employees;
    public int WhatIsConsideredDistant;
    public int ExtraTravelAllowanceBudget;
    public int MaxExtraTravelAllowance;
    public string LogLocation;
    public int ExtraTravelAllowanceDistant = 0;
    public Company()
    {
        Employees = new List<Employee>();
        WhatIsConsideredDistant = 25;
        ExtraTravelAllowanceBudget = 300;
        MaxExtraTravelAllowance = 100;
        LogLocation = "./Log.txt";
    }

    public void Hire(Employee employee) => Employees.Add(employee);

    public void PayMonthlySalary()
    {
        int howManyDistantEmployees = HowManyDistantEmployees();
        foreach (var employee in Employees)
        {
            int payout = employee.Salary + CalculateTravelAllowance(employee, howManyDistantEmployees);
            employee.SalaryEarned += payout;
        }
    }

    private int CalculateTravelAllowance(Employee employee, int howManyDistantEmployees)
    {
        var howManyCloseEmployees = Employees.Count - howManyDistantEmployees;
        var standardTravelAllowance = employee.DistanceFromCompany * 10;
        int extraTravelAllowanceClose = 0;
        try
        {
            ExtraTravelAllowanceDistant = Math.Min(ExtraTravelAllowanceBudget / howManyDistantEmployees, MaxExtraTravelAllowance);
            return standardTravelAllowance +
                (employee.DistanceFromCompany >= WhatIsConsideredDistant ?
                ExtraTravelAllowanceDistant : extraTravelAllowanceClose);
        }
        catch (DivideByZeroException ex)
        {
            string message = ex.Message;
            message =
                (howManyDistantEmployees == 0 ? "0 distant employees. " : "") +
                (howManyCloseEmployees == 0 ? "0 close employees. " : "") +
                message;
            LogException(message);
        }
        extraTravelAllowanceClose = Math.Min((ExtraTravelAllowanceBudget - ExtraTravelAllowanceDistant * howManyDistantEmployees) / howManyCloseEmployees, 100);
        return standardTravelAllowance + extraTravelAllowanceClose;
    }

    private int HowManyDistantEmployees()
    {
        int howMany = 0;
        foreach (var employee in Employees)
        {
            if (employee.DistanceFromCompany >= WhatIsConsideredDistant)
                howMany++;
        }
        return howMany;
    }

    private void LogException(string message)
    {
        try
        {
            File.AppendAllText(LogLocation, DateTime.Now + "\n" + message + "\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}