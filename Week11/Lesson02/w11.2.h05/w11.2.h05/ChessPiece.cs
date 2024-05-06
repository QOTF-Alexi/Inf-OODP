public abstract class ChessPiece
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsWhite { get; set; }
    public string Symbol { get; }

    public ChessPiece(int x, int y, bool isWhite)
    {
        X = x;
        Y = y;
        IsWhite = isWhite;
    }

    public virtual bool CanMove(int newX, int newY)
    {
        return newX >= 0 && newX <= 7 && newY >= 0 && newY <= 7;
    }

    public override string ToString()
    {
        return IsWhite ? $"White {base.ToString()} at ({X}, {Y})" : $"Black {base.ToString()} at ({X}, {Y})";
    }
}