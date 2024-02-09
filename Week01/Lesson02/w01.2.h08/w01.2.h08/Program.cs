public class Program
{
    public static void Main(string[] args)
    {
        List<double> grades = new List<double>();
        grades.Add(6.5);
        grades.Add(9.5);
        grades.Add(4);
        grades.Add(5);
        grades.Add(4.5);
        grades.Add(10);
        grades.Add(7.1);

        for (int i = 0; i < grades.Count; i++)
        {
            Console.WriteLine("Grade: " + grades[i]);
            if (grades[i] < 5.5)
            {
                string choice = "";
                do
                {
                    Console.WriteLine("Retake this course? y/n");
                    choice = Console.ReadLine().ToLower();
                } while (choice is not ("y" or "n"));

                if (choice == "y")
                {
                    grades[i] += 1;
                }
            }
        }

        Console.WriteLine("Final grades:");
        foreach (var t in grades)
        {
            Console.WriteLine(t);
        }
    }
}