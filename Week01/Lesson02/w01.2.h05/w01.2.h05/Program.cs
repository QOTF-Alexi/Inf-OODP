public class Program
{
    public static void Main()
    {
        double balance = 0;
        int taxesPaid = 0;
        Console.WriteLine("Please enter a balance");
        balance = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter an interest rate");
        double interest = (Convert.ToDouble(Console.ReadLine()) / 100) + 1;
        Console.WriteLine("Please enter an amount of years");
        int years = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= years; i++)
        {
            int tax = 0;
            balance = balance * interest;
            Console.WriteLine("DEBUG: Balance after interest addition: " + balance);
            if (balance > 50000 && balance <= 100000)
            {
                int payOver15 = Convert.ToInt32(((balance - 50000) * 0.015));
                tax = payOver15;
            }
            else if (balance > 100000)
            {
                int payOver15 = 750;
                int payOver30 = Convert.ToInt32(((balance - 100000) * 0.03));
                tax = payOver15 + payOver30;
            }
            balance -= tax;
            taxesPaid += tax;
            Console.WriteLine($"DEBUG: Tax: {tax}, balance: {balance}, tax paid: {taxesPaid}");
        }

        int intBalance = (int)(balance);
        Console.WriteLine($"Balance after {years} years: {intBalance}");
        Console.WriteLine("Amount of taxes paid: " + taxesPaid);
    }
}