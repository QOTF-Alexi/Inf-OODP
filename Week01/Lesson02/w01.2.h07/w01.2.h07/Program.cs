public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Give a number from 2-9:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 2)
        {
            number = 2;
        }
        else if (number > 9)
        {
            number = 9;
        }

        Console.Write("  |");
        for (int i = -1; i < number + 1; i++)
        {
            for (int j = 0; j <= number; j++)
            {
                if (i == -1)
                {
                    if (j > 0)
                    {
                        Console.Write("   " + j);
                    }
                }
                else if (i == 0)
                {
                    string repeatedString = new string('-', 4 * number + 4);
                    Console.Write(repeatedString);
                    break;
                }
                else
                {
                    if (j == 0)
                    {
                        Console.Write(i + " |");
                    }
                    else
                    {
                        int multiplication = i * j;
                        if (multiplication >= 10)
                        {
                            Console.Write("  " + multiplication);
                        }
                        else
                        {
                            Console.Write("   " + multiplication);
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}