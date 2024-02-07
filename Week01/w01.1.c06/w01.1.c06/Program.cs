Console.WriteLine("Give some text");
string text = Console.ReadLine();

Console.WriteLine("What do you want to do with this text?");
Console.WriteLine("U: make all uppercase");
Console.WriteLine("L: make all lowercase");
Console.WriteLine("Any other key: do not change");
string choice = Console.ReadLine().ToUpper();

string newText = choice switch
{
    "U" => text.ToUpper(),
    "L" => text.ToLower(),
    _ => text
};

Console.WriteLine(newText);