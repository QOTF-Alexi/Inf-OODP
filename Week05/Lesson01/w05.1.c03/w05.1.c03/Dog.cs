class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        Name = name;
        Sound = "Woof!";
    }

    public void Fetch()
    {
        Console.WriteLine(Name + " fetches the stick");
    }
}