public class CurrentConditionsDisplay : IObserver, IDisplay
{
    private IObservable _observable;
    private double _temperature;
    private double _humidity;

    public CurrentConditionsDisplay(IObservable observable)
    {
        _observable = observable;
    }

    public void Update()
    {
        if (_observable.GetType() == typeof(WeatherData))
        {
            _temperature = ((WeatherData) _observable).Temperature;
            _humidity = ((WeatherData) _observable).Humidity;
        }
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {_temperature}C degrees and {_humidity}% humidity");
    }
}
