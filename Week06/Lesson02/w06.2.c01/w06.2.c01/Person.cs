public abstract class Person
{
    public int Age { get; set; }
    public abstract string FirstName { get; set; }
    public abstract string LastName { get; set; }

    protected Person(string firstname, string lastname, int age)
    {
        FirstName = firstname;
        LastName = lastname;
        Age = age;
    }

    public abstract string Greet();

    public virtual string GetFullName() => $"{FirstName} {LastName}";
}