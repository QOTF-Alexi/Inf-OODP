public class Square : IDrawable, IResizable
{
    public int Size { get; private set; }
    public Square(int size) => Size = size;

    public void Resize(double scale)
    {
        Size = Convert.ToInt32(Size * scale);
    }

    public void Draw()
    {
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
        Console.Write("\n");
    }
}