public class Knight : ChessPiece
{
    public int X { get; set; }
    public int Y { get; set; }

    public Knight(int x, int y, bool isWhite) : base(x, y, isWhite)
    {
        X = x;
        Y = y;
    }
    
    public override bool CanMove(int x, int y) =>
        (x == X + 2 && y == Y + 1) || (x == X + 1 && y == Y + 2) || (x == X - 2 && y == Y + 1) ||
        (x == X - 1 && y == Y + 2) || (x == X + 2 && y == Y - 1) || (x == X + 1 && y == Y - 2) ||
        (x == X - 2 && y == Y - 1) || (x == X - 1 && y == Y - 2);
    
    public override string ToString()
    {
        return IsWhite ? $"White Knight at ({X}, {Y})" : $"Black Knight at ({X}, {Y})";
    }
}
