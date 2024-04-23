public static class TestResultProcessor
{
    public static Tuple<double, bool> GetTestResult(int obtainedPoints, int maxPoints)
    {
        double score = obtainedPoints / (double)maxPoints * 10.0;
        return new Tuple<double, bool>(score, score >= 5.5);
    }

    public static void PrintTestResult(Tuple<double, bool> t)
    {
        Console.WriteLine("Grade: " + t.Item1);
        Console.WriteLine(t.Item2 ? "Passed" : "Did not pass");
    }
}