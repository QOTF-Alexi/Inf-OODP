public class WeatherData
{
    //Change from List to array
    private readonly double[] _data;
    public int NumberOfReadings => _data.Length;
    public WeatherData(double[] data) => _data = data;

    public double GetHighestTemperature()
    {
        return _data.Max();
    }

    public void Sort(bool dir)
    {
        Array.Sort(_data);
        if (!dir)
        {
            Array.Reverse(_data);
        }
    }

    public void PrintTemperatures()
    {
        foreach (double temp in _data)
        {
            Console.WriteLine(temp);
        }
    }

    public Array GetTemperaturesSorted(bool dir)
    {
        double[] sortedData = new double[_data.Length];
        Array.Copy(_data, sortedData, _data.Length);
        Array.Sort(sortedData);
        if (!dir)
        {
            Array.Reverse(sortedData);
        }

        return sortedData;
    }
}