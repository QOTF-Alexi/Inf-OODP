class Vector2D
{
    public double X { get; }
    public double Y { get; }

    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public static Vector2D operator +(Vector2D v1, Vector2D v2)
    {
        var newVecX = v1.X + v2.X;
        var newVecY = v1.Y + v2.Y;
        return new Vector2D(newVecX, newVecY);
    }

    public override string ToString() => $"({X}, {Y})";
}