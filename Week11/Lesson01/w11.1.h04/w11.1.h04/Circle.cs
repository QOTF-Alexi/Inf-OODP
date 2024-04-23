public class Circle : Shape, ISelectable
{
    public bool IsSelected { get; set; } = false;
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius > 0) Radius = radius; else Radius = 0;
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