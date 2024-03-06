public class Point
{
    private double X;
    private double Y;

    public Point()
    {
        X = 0;
        Y = 0;
    }
    
    public Point(double X, double Y)
    {
        this.X = X;
        this.Y = Y;
    }

    public Point(Point point)
    {
        X = point.X;
        Y = point.Y;
    }

    public static double EuclideanDistance(Point p1, Point p2)
    {
        double dx = p1.X - p2.X;
        double dy = p1.Y - p2.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
}