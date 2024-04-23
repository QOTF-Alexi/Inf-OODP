public class MyCollection
{
    private int[] _data;
    public MyCollection(int size) => _data = new int[size];

    // Overload the [] indexer here
    // Define the indexer to allow client code to use [] notation.
    public int this[int i]
    {
        get { return _data[i]; }
        set { _data[i] = value; }
    }
}