public interface IChessPiece
{
    int X { get; set; }
    int Y { get; set; }
    bool IsWhite { get; set; }

    bool CanMove(int x, int y);

}