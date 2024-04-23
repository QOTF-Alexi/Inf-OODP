public class Tower<TShape> where TShape : IStackable
{
    TShape[] Shapes { get; }
    public int Index { get; set; } = 0;

    public Tower(int shapeSize)
    {
        Shapes = new TShape[shapeSize];
    }

    public Tower(Tower<TShape> otherTower)
    {
        Shapes = otherTower.Shapes;
    }

    public void Add(TShape shape)
    {
        if (Shapes.Count() < Shapes.Length)
        {
            Shapes.Append(shape);
        }
    }

    public static Tower<TShape> operator +(Tower<TShape> tower, TShape shape)
    {
        var newTower = new Tower<TShape>(tower);
        newTower.Add(shape);
        return newTower;
    }
}