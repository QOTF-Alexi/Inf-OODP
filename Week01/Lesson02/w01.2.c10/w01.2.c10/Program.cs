public class Program
{
    public static void Main(string[] args)
    {
        List<double> grades = new List<double>()
        {
            7, 5.5, 3.2, 10, 4.5
        };

        int countSufficients = 0;
        foreach (var t in grades)
        {
            if (t >= 5.5)
            {
                countSufficients += 1;
            }
            Console.WriteLine(t);
        }

        Console.WriteLine($"{countSufficients} out of {grades.Count} students passed");
    }
}