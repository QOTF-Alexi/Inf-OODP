class LimitedEditionCar
{
    public const string Model = "Volkswagen Golf Harlequin";
    public readonly string ChassisNumber;
    public static int Counter;

    public LimitedEditionCar()
    {
        Counter += 1;
        ChassisNumber = $"CHNO{Counter}";
    }
}