// Create the public enum Color
// with Red, Green and Blue here
public enum Color
{
    Red,
    Green,
    Blue
}



public static class ColorValidator
{
    public static void DisplayColors()
    {
        // Print all the colors here.
        // Make sure of Enum.GetValues() with typeof(Color)
        // to get an array with all the colors.
        var colors = Enum.GetValues(typeof(Color));
        foreach (var color in colors)
        {
            Console.WriteLine(color);
        }
        
    }

    public static bool ValidateColor(string input)
    {
        // Print "Valid color: " plus the color and return true, if it is valid
        // Print "Invalid color" and return false otherwise.
        if (!Enum.TryParse(input, out Color color))
        {
            Console.WriteLine("Invalid color");
            return false;
        }
        Console.WriteLine("Valid Color: " + color);
        return true;
    }
}