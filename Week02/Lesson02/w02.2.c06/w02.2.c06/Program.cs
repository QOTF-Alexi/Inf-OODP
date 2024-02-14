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

        foreach (Pet p in Pets)
        {
            Console.WriteLine($"I have a {p.WhatAmI} named {p.Name}");
        }

    }
}