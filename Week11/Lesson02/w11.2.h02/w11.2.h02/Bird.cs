public class Bird : Animal
{
    public int FlightDistanceInKM { get; }

    public Bird(string species, int age, int flightDistanceInKm) : base(species, age)
    {
        FlightDistanceInKM = flightDistanceInKm;
    }
}