public static class Fibonacci
{
    private static Dictionary<long, long> memo = new Dictionary<long, long>();

    public static long Calculate(long n)
    {
        if (n <= 1)
        {
            return n;
        }

        if (!memo.ContainsKey(n))
        {
            memo[n] = Calculate(n - 1) + Calculate(n - 2);
        }

        return memo[n];
    }
}