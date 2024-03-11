class Cat : Animal
{
    public Cat(string name) : base(name)
    {
        Name = name;
        Sound = "Meow!";
    }

    public void Climb()
    {
        Console.WriteLine(Name + " climbs the curtains");
    }
}