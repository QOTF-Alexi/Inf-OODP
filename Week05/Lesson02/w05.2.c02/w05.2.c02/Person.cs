public class Person
{
    private string _firstname;
    private string _lastname;

    public Person(string firstname, string lastname)
    {
        _firstname = firstname;
        _lastname = lastname;
    }

    public string FullName
    {
        get { return $"{_firstname} {_lastname}"; }
    }
}