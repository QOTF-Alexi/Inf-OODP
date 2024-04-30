public class Board
{
    public ChessPiece[,] ChessBoard = new ChessPiece[8, 8];

    public void PlacePiece(ChessPiece piece)
    {
        ChessBoard[piece.X, piece.Y] = piece;
    }

    public void MovePiece(ChessPiece piece, int x, int y)
    {
        if (piece.CanMove(x, y))
        {
            ChessBoard[x, y] = piece;
            ChessBoard[piece.X, piece.Y] = null;
            piece.X = x; piece.Y = y;
        }
        else Console.WriteLine("Invalid move for " + piece.ToString());
    }

    public void Print()
    {
        int newLiner = 0;
        foreach (var piece in ChessBoard)
        {
            if (newLiner == 7)
            {
                Console.Write("\n");
                newLiner = 0;
            }
            if (piece is null) { Console.Write("    -"); }
            else { Console.Write($" {piece.Symbol} -"); }
            newLiner++;
        }
        Console.Write("\n");
    }
}