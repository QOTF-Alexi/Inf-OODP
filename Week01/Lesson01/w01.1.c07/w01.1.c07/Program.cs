string word = "Length";
Console.WriteLine("You have one chance to guess this six-letter word:");
Console.WriteLine("Le..th");
string guess = Console.ReadLine();

if (word == guess)
{
    Console.WriteLine("Correct!");
}
else if (word.ToLower() == guess || word.ToUpper() == guess)
{
    Console.WriteLine("Kind of correct; the case was just wrong");
}
else if (guess.Length > 6 || guess.Length < 6)
{
    Console.WriteLine("Incorrect! That is not even a six-letter word!");
}
else
{
    Console.WriteLine("Incorrect!");
}