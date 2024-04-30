public class Knight : ChessPiece
{
    public string Symbol { get => IsWhite ? "WKn" : "BKn"; }

    public Knight(int x, int y, bool isWhite) : base(x, y, isWhite)
    {
    }

    public override bool CanMove(int x, int y) =>
        base.CanMove(x, y) && ((x == X + 2 && y == Y + 1) || (x == X + 1 && y == Y + 2) || (x == X - 2 && y == Y + 1) ||
        (x == X - 1 && y == Y + 2) || (x == X + 2 && y == Y - 1) || (x == X + 1 && y == Y - 2) ||
        (x == X - 2 && y == Y - 1) || (x == X - 1 && y == Y - 2));
}
