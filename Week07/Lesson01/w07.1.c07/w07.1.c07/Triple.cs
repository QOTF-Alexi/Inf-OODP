public class Triple<T1, T2, T3> : Pair<T1,T2>
{
    public T3 Trd { get; private set; }

    public Triple(T1 t1,  T2 t2, T3 t3) : base(t1, t2)
    {
        Trd = t3;
    }
}