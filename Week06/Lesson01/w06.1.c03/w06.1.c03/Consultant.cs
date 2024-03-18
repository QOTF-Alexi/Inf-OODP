public class Consultant : IPayable
{
    public string Name { get; set; }
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public Consultant(string name, double hourlyRate)
    {
        Name = name;
        HourlyRate = hourlyRate;
    }
    
    public double GetPaymentAmount()
    {
        return HoursWorked * HourlyRate;
    }
    
    public string Info
    {
        get => $"{Name}; {HourlyRate}/hour";
    }
}