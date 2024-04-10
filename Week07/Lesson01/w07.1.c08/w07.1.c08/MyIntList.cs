public class MyIntList : MyGenericList<int>
{
    public MyIntList(List<int> ints) : base(ints)
    {

    }

    public override int Combine()
    {
        int combined = 0;
        foreach(var item in Elems)
        {
            combined += item;
        }
        return combined;
    }
}