class Sudoku
{
    public int[,] Board { get; }
    public Sudoku(int[,] board) => Board = board;

    public int this[int row, int col]
    {
        get => Board[row, col]; // Get the value at the specified position
        set => Board[row, col] = value; // Set the value at the specified position
    }
}