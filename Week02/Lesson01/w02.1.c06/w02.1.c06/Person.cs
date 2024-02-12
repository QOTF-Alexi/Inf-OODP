class Person
{
    public string FirstName;
    public string LastName;
    public Person(string inFirstName, string inLastName)
    {
        FirstName = inFirstName;
        LastName = inLastName;
    }
    //Write the fields and the constructor here

    public string Introduce() => $"I am {FirstName} {LastName}";
}