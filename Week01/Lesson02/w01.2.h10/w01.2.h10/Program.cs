public class Program
{
    public static void Main()
    {
        Console.WriteLine("Time to play Guess The Number!");
        Console.WriteLine("Give the minimum number:");
        int inMin = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Give the maximum number:");
        int inMax = Convert.ToInt32(Console.ReadLine());
        int min;
        int max;
        if (inMin > inMax)
        {
            Console.WriteLine("The minimum is higher than the maximum. Switching values.");
            max = inMin;
            min = inMax;
        }
        else
        {
            min = inMin;
            max = inMax;
        }

        if (min == max)
        {
            Console.WriteLine("The minimum and maximum are equal. Incrementing the maximum by 1.");
            max += 1;
        }

        Random randomGenerator = new Random(0);
        int randInt = randomGenerator.Next(min, max);
        bool won = false;
        while (won == false)
        {
            Console.WriteLine($"Guess the number [{min}-{max}]");
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == randInt)
            {
                Console.WriteLine(guess + " is correct!");
                won = true;
            }
            else if (guess < randInt)
            {
                Console.WriteLine("Higher!");
            }
            else if (guess > randInt)
            {
                Console.WriteLine("Lower!");
            }
        }

        string playAnother = "";
        Console.WriteLine("Do you wish to play another round? Y to continue");
        playAnother = Console.ReadLine().ToLower();
        if (playAnother == "y")
        {
            won = false;
            Main();
        }
        else
        {
            Console.WriteLine("Thank you for playing!");
        }
    }
}