public class WeatherData : IObservable
{
    private List<IObserver> _observers = new List<IObserver>();
    public double Temperature { get; set; }
    public double Humidity { get; set; }
    public double Pressure { get; set; }

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void SetMeasurements(double temperature, double humidity, double pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
        MeasurementsChanged();
    }

    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }
}
