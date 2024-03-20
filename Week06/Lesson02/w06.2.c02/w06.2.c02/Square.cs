public class Square : Shape
{
    public double Length { get; set; }

    public override double Area => Math.Pow(Length, 2);

    public override double Perimeter => Length * 4;

    public Square(double length)
    {
        Length = length;
    }

    public override string Info()
    {
        return $"Square with sides of {Length}";
    }
}