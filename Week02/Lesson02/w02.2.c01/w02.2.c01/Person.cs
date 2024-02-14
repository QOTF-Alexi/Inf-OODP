public class Person
{
    public string FirstName;
    public Job DayJob;
    
    public Person(string firstName, Job dayJob)
    {
        FirstName = firstName;
        DayJob = dayJob;
    }

    public string Info()
    {
        if (DayJob == null)
        {
            return $"{FirstName} is in between jobs";
        }
        else
        {
            return $"{FirstName} works as a {DayJob.Name}";
        }
    }
}