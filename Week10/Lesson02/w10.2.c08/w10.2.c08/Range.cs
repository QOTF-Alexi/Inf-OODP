public class Range
{
    public readonly int Start;
    public readonly int End;
    public readonly int Step;

    public Range(int start, int end, int step)
    {
        Start = start;
        End = end;
        Step = step;
    }

    public IEnumerable<int> Next()
    {
        for (int i = Start; i < End; i += Step)
        {
            yield return i;
        }
    }
}