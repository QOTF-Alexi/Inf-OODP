public class Program
{
    public static void Main(string[] args)
    {
        const int spdOfLightInMperS = 299792458;
        const double daysInYear = 365.242199;
        const string planetName = "LP 890-9b";
        const double distanceFromEarthInLightYear = 100;
        
        decimal distanceInMetre = (decimal)spdOfLightInMperS * 3600 * 24 * (decimal)daysInYear * (decimal)distanceFromEarthInLightYear;

        Console.WriteLine($"The planet {planetName} is {distanceFromEarthInLightYear} lightyears away from Earth");
        Console.WriteLine($"In meters this is {distanceInMetre:0.###############E+0}");
    }
}