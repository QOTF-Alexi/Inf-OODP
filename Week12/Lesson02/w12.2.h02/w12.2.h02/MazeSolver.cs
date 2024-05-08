static class MazeSolver
{
    public const char Path = ' ';
    public const char Wall = 'X';
    public const char Mark = 'o';

    public static bool Solve(char[,] maze, int startX, int startY, int endX, int endY)
    {
        // Base case: If the current position is the end position, return true
        if (startX == endX && startY == endY)
            return true;

        if (startX >= 0 && startX < maze.GetLength(0) &&
            startY >= 0 && startY < maze.GetLength(1))
        {
            // Mark the current position
            maze[startX, startY] = Mark;
        }
        else return false;

        // Check all four directions: up, down, left, and right
        int[] dx = { 0, 0, -1, 1 };
        int[] dy = { -1, 1, 0, 0 };

        for (int i = 0; i < 4; i++)
        {
            int nextX = startX + dx[i];
            int nextY = startY + dy[i];

            // Check if the next position is within bounds
            if (nextX >= 0 && nextX < maze.GetLength(0) &&
                nextY >= 0 && nextY < maze.GetLength(1) &&
                maze[nextX, nextY] == Path)
            {
                // Recursively explore the next position
                if (Solve(maze, nextX, nextY, endX, endY))
                    return true;
            }
        }

        // Unmark the current position (backtrack)
        maze[startX, startY] = Path;
        return false;
    }

    public static void PrintMaze(char[,] maze)
    {
        int rows = maze.GetLength(0);
        int cols = maze.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(maze[i, j] + " "); // Open path
            }
            Console.WriteLine();
        }
    }
}