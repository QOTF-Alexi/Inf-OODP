Console.Write("Input string: ");
var str = Console.ReadLine();
var charFrequencies = 
    from c in str 
    group c by c into charGroup
    select new
    {
        Character = charGroup.Key,
        Frequency = charGroup.Count()
    };

foreach (var item in charFrequencies)
{
    Console.WriteLine($"Char [{item.Character}]: {item.Frequency}");
}