public static class TestResultProcessor
{
    public static (double, bool) GetTestResult(int obtainedPoints, int maxPoints)
    {
        double score = obtainedPoints / (double)maxPoints * 10.0;
        return (score, score >= 5.5);
    }

    public static void PrintTestResult((double, bool) t)
    {
        Console.WriteLine("Grade: " + t.Item1);
        Console.WriteLine(t.Item2 ? "Passed" : "Did not pass");
    }
}