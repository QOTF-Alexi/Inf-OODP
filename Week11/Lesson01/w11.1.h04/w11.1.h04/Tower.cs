public class Tower<TShape> where TShape : IStackable
{
    TShape[] Shapes { get; }
    private int _currentIndex = 0;
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
        if (_currentIndex < Shapes.Length)
        {
            Shapes[_currentIndex] = shape;
            _currentIndex++;
        }
    }

    public static Tower<TShape> operator +(Tower<TShape> tower, TShape shape)
    {
        var newTower = new Tower<TShape>(tower);
        newTower.Add(shape);
        return newTower;
    }
}