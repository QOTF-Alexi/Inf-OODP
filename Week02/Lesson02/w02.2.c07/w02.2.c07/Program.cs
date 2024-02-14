public class Program
{
    public static void Main()
    {
        List<Pet> Pets = new()
        {
            new Pet("Dog", "Nugent"),
            new Pet("Cat", "Steve"),
            new Pet("Goldfish", "Brutus")
        };

        Person John = new Person("John", Pets);

        foreach (Pet p in John.Pets)
        {
            Console.WriteLine($"{John.Name} has a {p.WhatAmI} named {p.Name}");
        }

    }
}