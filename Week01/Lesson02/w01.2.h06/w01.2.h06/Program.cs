public class Program
{
    public static void Main(string[] args)
    {
        int size = 0;
        do
        {
            Console.WriteLine("Enter the board size");
            size = Convert.ToInt32(Console.ReadLine());
        } while (size < 2);

        for (int i = size - 1; i >= 0; i--)
        {
            for (int j = 0; j < size; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    Console.Write("B");
                }
                else
                {
                    Console.Write("W");
                }
            }
            Console.WriteLine();
        }
    }
}