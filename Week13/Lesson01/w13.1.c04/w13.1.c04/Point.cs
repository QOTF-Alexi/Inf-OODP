public class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    // GetDistanceCalculator goes here
    public static Func<Point, Point, double> GetDistanceCalculator(double scalingFactor)
    {
        return (p1, p2) =>
        {
            double deltaX = p2.X - p1.X;
            double deltaY = p2.Y - p1.Y;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return distance * scalingFactor;
        };
    }
}