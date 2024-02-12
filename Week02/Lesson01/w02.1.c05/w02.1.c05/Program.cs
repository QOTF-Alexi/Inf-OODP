class Program
{
    public static void Main()
    {
        Square fiveSquare = new Square(5);
        Square tenSquare = new Square(10);
        Console.WriteLine("Side: " + fiveSquare.Side);
        Console.WriteLine("Area: " + fiveSquare.Area());
        Console.WriteLine("Perimeter: " + fiveSquare.Perimeter());
        
        Console.WriteLine("Side: " + tenSquare.Side);
        Console.WriteLine("Area: " + tenSquare.Area());
        Console.WriteLine("Perimeter: " + tenSquare.Perimeter());
    }
}