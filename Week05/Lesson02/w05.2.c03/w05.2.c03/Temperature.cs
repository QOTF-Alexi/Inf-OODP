public class Temperature
{
    private double _celsius;

    public double Celsius
    {
        get => _celsius;
        set
        {
            if (value >= -273.15)
            {
                _celsius = value;
            }
        }
    }

    public double Kelvin
    {
        get { return Celsius + 273.15; }
        set
        {
            if (value >= 0)
            {
                _celsius = value - 273.15;
            }
        }
    }
}