public class StatisticsDisplay : IObserver, IDisplay
{
    private IObservable _observable;
    private double _minTemperature = 99.9;
    private double _maxTemperature;
    private List<double> _temperatures = new List<double>();
    private double _averageTemperature;

    public StatisticsDisplay(IObservable observable)
    {
        _observable = observable;
    }

    public void Update()
    {
        if (_observable.GetType() == typeof(WeatherData))
        {
            _temperatures.Add(((WeatherData)_observable).Temperature);
            _averageTemperature = _temperatures.Average();
            if (((WeatherData)_observable).Temperature < _minTemperature)
            {
                _minTemperature = ((WeatherData)_observable).Temperature;
            }
            if (((WeatherData)_observable).Temperature > _maxTemperature)
            {
                _maxTemperature = ((WeatherData)_observable).Temperature;
            }
        }
    }

    public void Display()
    {
        Console.WriteLine($"Avg/Min/Max temperature = {_averageTemperature}/{_minTemperature}/{_maxTemperature}");
    }
}
