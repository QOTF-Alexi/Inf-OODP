// V Your code goes below V
string colour = "";
int chosen_num = 0;

do
{
    Console.WriteLine("Pick a color (red/blue/green/yellow):");
    colour = Console.ReadLine();
} while (colour is not ("red" or "blue" or "green" or "yellow"));
int colourWordLength = colour.Length;

do
{
    Console.WriteLine("Pick a number (1-8):");
    chosen_num = Convert.ToInt32(Console.ReadLine());
} while (chosen_num > 8 || chosen_num < 1);

int fortuneNumber = (colourWordLength + chosen_num) % 4 + 1;

// ^ Your code goes above ^
//No need to look below here for this assignment. But you are welcome to!
PrintFortune(fortuneNumber);

static void PrintFortune(int fortuneNumber)
{
    string fortune = fortuneNumber switch
    {
        1 => "You will be loved and be happy!",
        2 => "You will be loved and be rich!",
        3 => "You will be loved and be famous!",
        4 => "You will be loved, and you'll be happy, rich and famous!",
        _ => "Unknown. :( But you will still be loved, no matter what."
    };
    Console.WriteLine(fortune);
}