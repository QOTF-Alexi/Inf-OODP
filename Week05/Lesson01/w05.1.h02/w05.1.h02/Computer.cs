public class Computer : Electronics
{
    public Computer(string name, double price, int stock, string brand, string model) : base(name, price, stock, brand, model)
    {

    }

    public override void Sell(int units)
    {
        base.Sell(units);
        OfferAssistance();
    }

    private void OfferAssistance()
    {
        Console.WriteLine("Call for installation help: 1234HELPME");
    }
}