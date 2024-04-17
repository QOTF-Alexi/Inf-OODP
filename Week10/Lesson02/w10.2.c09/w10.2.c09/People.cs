using System.Collections;

public class People : IEnumerable
{
    public List<Person> Persons = new();

    public void Add(Person person)
    {
        Persons.Add(person);
    }

    public IEnumerator GetEnumerator()
    {
        foreach (Person p in Persons)
        {
            yield return p;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}