public class Knight : IChessPiece
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsWhite { get; set; }

    public Knight(int x, int y, bool isWhite)
    {
        X = x;
        Y = y;
        IsWhite = isWhite;
    }
    
    public bool CanMove(int x, int y) =>
        (x == X + 2 && y == Y + 1) || (x == X + 1 && y == Y + 2) || (x == X - 2 && y == Y + 1) ||
        (x == X - 1 && y == Y + 2) || (x == X + 2 && y == Y - 1) || (x == X + 1 && y == Y - 2) ||
        (x == X - 2 && y == Y - 1) || (x == X - 1 && y == Y - 2);
    
    public override string ToString()
    {
        return IsWhite ? $"White Knight at ({X}, {Y})" : $"Black Knight at ({X}, {Y})";
    }
}
