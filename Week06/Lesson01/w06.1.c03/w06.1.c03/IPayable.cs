public interface IPayable
{
    public string Name { get; set; }
    public string Info { get; }

    public double GetPaymentAmount();
}