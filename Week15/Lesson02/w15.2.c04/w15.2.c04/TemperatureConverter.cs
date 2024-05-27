public enum TemperatureUnit
{
    Celsius,
    Fahrenheit,
    Kelvin
}

public static class TemperatureConverter
{
    public static string ConvertToString(TemperatureUnit unit)
    {
        //takes a TemperatureUnit and returns "C", "F" or "K", depending on the parameter.
        switch (unit)
        {
            case TemperatureUnit.Celsius:
                return "C";
            case TemperatureUnit.Fahrenheit:
                return "F";
            case TemperatureUnit.Kelvin:
                return "K";
            default:
                return "INVALID";
        }
    }

    public static TemperatureUnit ConvertToEnum(string unit)
    {
        //takes a string ("C", "F" or "K") and returns the corresponding TemperatureUnit (Celsius, Fahrenheit or Kelvin).
        //If the parameter is not either "C", "F" or "K", throw an ArgumentException with the text "Invalid temperature unit string".
        if (unit is not "C" and not "F" and not "K")
        {
            throw new ArgumentException("Invalid temperature unit string");
        }

        switch (unit)
        {
            case "C":
                return TemperatureUnit.Celsius;
            case "F":
                return TemperatureUnit.Fahrenheit;
            case "K":
                return TemperatureUnit.Kelvin;
            default:
                return default;
        }
    }
    
    //Pro tip: create methods ConvertToString and ConvertToEnum as switch expressions
}