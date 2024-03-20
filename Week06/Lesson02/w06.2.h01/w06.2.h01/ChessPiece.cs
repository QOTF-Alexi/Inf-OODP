public abstract class ChessPiece
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsWhite { get; set; }

    public ChessPiece(int x, int y, bool isWhite)
    {
        X = x;
        Y = y;
        IsWhite = isWhite;
    }

    public abstract bool CanMove(int x, int y);
}