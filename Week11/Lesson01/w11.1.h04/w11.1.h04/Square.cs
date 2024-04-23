public class Square : ISelectable, IStackable
{
    public bool IsSelected { get; set; } = false;
    public double Size { get; }

    public Square(double size)
    {
        if (size > 0) Size = size; else Size = 0;
    }

    public void Select()
    {
        IsSelected = true;
    }

    public void Deselect()
    {
        IsSelected = false;
    }
}
}