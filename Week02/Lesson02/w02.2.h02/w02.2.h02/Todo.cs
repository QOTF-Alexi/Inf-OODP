class Todo
{
    List<Task> TaskList = new List<Task>();

    public void AddTask(string Name)
    {
        TaskList.Add(new Task(Name));
    }

    public Task GetTask(string SearchTerm)
    {
        foreach (Task t in TaskList)
        {
            if (t.Name == SearchTerm)
            {
                return t;
            }
        }
        return null;
    }

    public void Report()
    {
        foreach (Task t in TaskList)
        {
            Console.WriteLine(t.Info());
        }
    }
}