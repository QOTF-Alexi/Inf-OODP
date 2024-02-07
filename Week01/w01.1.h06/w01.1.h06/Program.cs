// Converts the input string into a boolean.
static bool StrToBool(string input)
{
    return input switch
    {
        "Y" => true,
        _ => false
    };
}


// Setup.
Console.WriteLine("For each direction, input Y/N if it is valid.");
Console.WriteLine("North? Y/N");
string nValidstr = Console.ReadLine().ToUpper();
bool nValid = StrToBool(nValidstr);
Console.WriteLine("East? Y/N");
string eValidstr = Console.ReadLine().ToUpper();
bool eValid = StrToBool(eValidstr);
Console.WriteLine("South? Y/N");
string sValidstr = Console.ReadLine().ToUpper();
bool sValid = StrToBool(sValidstr);
Console.WriteLine("West? Y/N");
string wValidstr = Console.ReadLine().ToUpper();
bool wValid = StrToBool(wValidstr);
Console.WriteLine("Give a bearing (a number) for the direction in which you are going.");
int bearing = Convert.ToInt32(Console.ReadLine());
while (bearing > 360)
{
    bearing -= 360;
}
while (bearing < 0)
{
    bearing += 360;
}


// Draw a compass.
Console.WriteLine("From here you can go:");
if (nValid)
{
    Console.WriteLine("    N\n    |");
}
if (eValid & wValid)
{
    Console.WriteLine("W---|---E");
}
if (eValid & !wValid)
{
    Console.WriteLine("    |---E");
}
if (!eValid & wValid)
{
    Console.WriteLine("W---|");
}
if (!eValid & !wValid)
{
    Console.WriteLine("    |");
}
if (sValid)
{
    Console.WriteLine("    |\n    S");
}


// Convert the bearing into a heading.
string heading = bearing switch
{
    (> 315 and <= 360) or (<= 45 and >= 0) => "North",
    > 45 and <= 135 => "East",
    > 135 and <= 225 => "South",
    > 225 and <= 315 => "West",
    _ => "Invalid direction"
};


// Evaluate if the move is valid.
bool validMove;
if (heading == "North" & !nValid)
{
    validMove = false;
}
else if (heading == "East" & !eValid)
{
    validMove = false;
}
else if (heading == "South" & !sValid)
{
    validMove = false;
}
else if (heading == "West" & !wValid)
{
    validMove = false;
}
else
{
    validMove = true;
}

// Say the direction, if valid.
if (validMove)
{
    Console.WriteLine("\nYou are going " + heading);
}
else
{
    Console.WriteLine("\nYou can't go " + heading);
}