public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a start number");
        int startNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter an end number");
        int endNum = Convert.ToInt32(Console.ReadLine());

        for (int i = startNum; i <= endNum; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}