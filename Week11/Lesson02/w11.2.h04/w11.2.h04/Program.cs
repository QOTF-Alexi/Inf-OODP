namespace TicTacToe
{
    class Program
    {
        // The Tic-Tac-Toe board represented as an array
        static string[,] board = new string[3, 3]
        {
            { " ", " ", " " },
            { " ", " ", " " },
            { " ", " ", " " }
        };
        static int currentPlayer = 1; // Player 1 starts (X)
        static int choice;
        static int gameStatus = 0; // 0: In progress, 1: Player X wins, 2: Player O wins, 3: Tie

        static void Main(string[] args)
        {
            do
            {
                PrintBoard();
                // Display whose turn it is
                if (currentPlayer % 2 == 0)
                    Console.Write("Player O, please enter your move (row, column): ");
                else
                    Console.Write("Player X, please enter your move (row, column): ");
                // Get user input for the move
                string input = Console.ReadLine();
                if (input == "q") Environment.Exit(0);
                string[] coordinates = input.Split(',');
                int row = int.Parse(coordinates[0]) - 1;
                int column = int.Parse(coordinates[1]) - 1;

                // Check if the chosen position is valid and not already marked
                if (row <= 3 && row >= 0 && column <= 3 && column >= 0 && (board[row, column] != "X" && board[row, column] != "O"))
                {
                    if (currentPlayer % 2 == 0)
                        board[row, column] = "O";
                    else
                        board[row, column] = "X";

                    currentPlayer++;
                    gameStatus = CheckWin();
                }
                else
                {
                    Console.WriteLine("Invalid move!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            } while (gameStatus == 0);

            PrintBoard();

            if (gameStatus == 1)
                Console.WriteLine("Player X wins!");
            else if (gameStatus == 2)
                Console.WriteLine("Player O wins!");
            else
                Console.WriteLine("It's a tie!");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // Check if there's a winner or if the game is a tie
        static int CheckWin()
        {
            // check for x
            if (board[0, 0] == "X" && board[1, 0] == "X" && board[2, 0] == "X")
                return 1;
            else if (board[0, 1] == "X" && board[1, 1] == "X" && board[2, 1] == "X")
                return 1;
            else if (board[0, 2] == "X" && board[1, 2] == "X" && board[2, 2] == "X")
                return 1;

            else if (board[0, 0] == "X" && board[0, 1] == "X" && board[0, 2] == "X")
                return 1;
            else if (board[1, 0] == "X" && board[1, 1] == "X" && board[1, 2] == "X")
                return 1;
            else if (board[2, 0] == "X" && board[2, 1] == "X" && board[2, 2] == "X")
                return 1;

            else if (board[0, 0] == "X" && board[1, 1] == "X" && board[2, 2] == "X")
                return 1;
            else if (board[0, 2] == "X" && board[1, 1] == "X" && board[2, 0] == "X")
                return 1;

            // check for O
            if (board[0, 0] == "O" && board[1, 0] == "O" && board[2, 0] == "O")
                return 2;
            else if (board[0, 1] == "O" && board[1, 1] == "O" && board[2, 1] == "O")
                return 2;
            else if (board[0, 2] == "O" && board[1, 2] == "O" && board[2, 2] == "O")
                return 2;

            else if (board[0, 0] == "O" && board[0, 1] == "O" && board[0, 2] == "O")
                return 2;
            else if (board[1, 0] == "O" && board[1, 1] == "O" && board[1, 2] == "O")
                return 2;
            else if (board[2, 0] == "O" && board[2, 1] == "O" && board[2, 2] == "O")
                return 2;

            else if (board[0, 0] == "O" && board[1, 1] == "O" && board[2, 2] == "O")
                return 2;
            else if (board[0, 2] == "O" && board[1, 1] == "O" && board[2, 0] == "O")
                return 2;

            else if (currentPlayer == 10)
                return 3; // It's a tie
            else
                return 0; // Game still in progress
        }

        // Print the Tic-Tac-Toe board
        static void PrintBoard()
        {
            Console.WriteLine($" {board[0,0]} | {board[0,1]} | {board[0,2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[1,0]} | {board[1,1]} | {board[1,2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[2,0]} | {board[2,1]} | {board[2,2]} ");
        }
    }
}