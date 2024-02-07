int xCoord = 0;
int yCoord = 0;

Console.WriteLine("What direction would you like to go?\nUp\nDown\nRight\nLeft");
string choice = Console.ReadLine().ToUpper();
switch(choice)
{
    case "UP":
        yCoord += 1;
        break;
    case "DOWN":
        yCoord -= 1;
        break;
    case "LEFT":
        xCoord -= 1;
        break;
    case "RIGHT":
        xCoord += 1;
        break;
    default:
        Console.WriteLine("Invalid direction");
        break;
}

Console.WriteLine("Current position");
Console.WriteLine("X:" + xCoord + ", Y:" + yCoord);