var array = new int[][] {
    new int[]{ 1, 2, 3, 4, 5 },
    new int[]{ 6, 7, 8, 9, 10 },
    new int[]{ 11, 12, 13, 14, 15 },
    new int[]{ 16, 17, 18, 19, 20 },
    new int[]{ 21, 22, 23, 24, 25 }
};

int columnCount = array[0].Length;
var rowList = array
    .SelectMany(x => x)
    .Select((x, i) => new { Value = x, Index = i })
    .GroupBy(x => (x.Index + 1) % columnCount)
    .Select(g => g.Select(x => x.Value).ToArray())
    .ToArray();

foreach (var row in rowList)
{
    foreach (var col in row)
    {
        Console.Write(col);
    }
    Console.Write("\n");
}