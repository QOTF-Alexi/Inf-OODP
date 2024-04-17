class Program
{
    static void Main()
    {
        Vector2D vector1 = new(2.0, 3.0);
        Vector2D vector2 = new(1.5, 2.5);
        Vector2D vector3 = new(-2.5, -3.0);

        Vector2D vector4 = vector1 + vector2;// Add vector1 and vector2 using the + operator
        Vector2D vector5 = vector2 + vector3 + vector4; // Add vector2, vector3 and vector4 using the + operator

            Console.WriteLine($"Vector 4: {vector4}");
        Console.WriteLine($"Vector 5: {vector5}");
    }
}