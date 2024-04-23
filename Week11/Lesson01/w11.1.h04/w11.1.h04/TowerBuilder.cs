public static class TowerBuilder
{
    public static void build<TShape>(Tower<TShape> tower, TShape shape) where TShape : ISelectable, IStackable
    {
        shape.Select();
        tower.Add(shape);
    }
}