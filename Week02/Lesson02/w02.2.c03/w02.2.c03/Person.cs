public class Person
{
    public string Name;
    public Animal Pet;
    public string info;

    public Person(string name, Animal pet)
    {
        Name = name;
        Pet = pet;
    }
    public string Info()
    {
        if (Pet != null)
        {
            info = $"{Name} has a pet that makes the sound {Pet.MakeSound()}";
        }
        else
        {
            info = $"{Name} has no pet";
        }

        return info;
    }
}