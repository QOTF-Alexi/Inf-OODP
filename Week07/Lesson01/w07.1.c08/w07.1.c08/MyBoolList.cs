public class MyBoolList : MyGenericList<bool>
{
    public MyBoolList(List<bool> bools) : base(bools)
    {

    }

    public override bool Combine()
    {
        int truesAmount = 0;
        foreach (var item in Elems)
        {
            if (item == true) truesAmount++;
        }
        return truesAmount == Elems.Count;
    }
}