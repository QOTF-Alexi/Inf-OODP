public class Circle : Shape
{
    public double Radius { get; set; }
    public override double Area => Math.PI * Math.Pow(Radius, 2);
    public override double Perimeter => 2 * Math.PI * Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }
    
    public override string Info()
    {
        return $"Circle with a radius of {Radius}";
    }
}