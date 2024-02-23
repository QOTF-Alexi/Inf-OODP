class Task
{
    public string Name;
    public bool IsDone = false;

    public Task(string Name)
    {
        this.Name = Name;
    }

    public void Done()
    {
        IsDone = true;
    }

    public string Info()
    {
        if (!IsDone)
        {
            return $"Task: {Name}, Status: Pending";
        }
        return $"Task: {Name}, Status: Done";
    }
}
