public class Bishop : ChessPiece
{
    public string Symbol { get => IsWhite ? "WBi" : "BBi"; }

    public Bishop(int x, int y, bool isWhite) : base(x, y, isWhite)
    {
    }

    public override bool CanMove(int newX, int newY)
    {
        return base.CanMove(newX, newY) &&
            ((X - 1 == newX && Y + 1 == newY) ||
             (X + 1 == newX && Y + 1 == newY) ||
             (X - 1 == newX && Y - 1 == newY) ||
             (X + 1 == newX && Y - 1 == newY));
    }
}