public class Program
{
    public static void Main()
    {
        Console.WriteLine("What is the amount to pay?");
        int toPay = Convert.ToInt32(Console.ReadLine());
        int start = toPay;
        while (toPay > 0)
        {
            Console.WriteLine("\n" + toPay + " left to pay");
            Console.WriteLine("Pay how much?");
            Console.WriteLine("1: 5\n2: 10\n3: 20\n4: 50");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    toPay -= 5;
                    break;
                case "2":
                    toPay -= 10;
                    break;
                case "3":
                    toPay -= 20;
                    break;
                case "4":
                    toPay -= 50;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }

        if (toPay < 0)
        {
            string tipMe = "";
            do
            {
                Console.WriteLine("You paid " + toPay * -1 + " too much. Give a tip? y/n");
                tipMe = Console.ReadLine().ToLower();
            } while (tipMe is not ("y" or "n"));
            if (tipMe == "y")
            {
                int tipped = start + (toPay * -1);
                Console.WriteLine("You have paid " + tipped);
            }
            else
            {
                Console.WriteLine("You have paid " + start);
            }

        }
        else
        {
            Console.WriteLine("You have paid " + start);
        }
    }
}