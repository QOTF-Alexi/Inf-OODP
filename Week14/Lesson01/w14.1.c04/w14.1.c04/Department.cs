public class Department
{
    public string Name;
    private Queue<Request> _requests;

    public Department(string name)
    {
        Name = name;
        _requests = new Queue<Request>();
    }

    public void AddRequest(Request request)
    {
        _requests.Enqueue(request);
    }

    public Request SolveNextRequest()
    {
        return _requests.Dequeue();
    }

    public Request GetNextRequest()
    {
        return _requests.Peek();
    }

    public void PrintAllRequests()
    {
        foreach (var request in _requests)
        {
            Console.WriteLine(request.ToString());
        }
    }
}