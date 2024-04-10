public class ListWrapper<T>
{
    private List<T> _myList;

    public ListWrapper()
    {
        _myList = new List<T>();
    }

    public void Add(T item)
    {
        _myList.Add(item);
    }

    public T Get(int index)
    {
        return _myList[index];
    }

    public int Count => _myList.Count;

    public int HighestCount<T2>(ListWrapper<T2> toCompare)
    {
        int myCount = _myList.Count;
        int compareCount = toCompare.Count;
        return myCount > compareCount ? myCount : compareCount;
    }
}