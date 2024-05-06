public class ParkingSpace
{
    public int Row { get; }
    public int Col { get; }
    public int Size { get; }

    private bool _isOccupied;
    public bool IsOccupied { get => _isOccupied; }

    private Vehicle? _parkedVehicle;
    public Vehicle ParkedVehicle { get => IsOccupied ? _parkedVehicle : null; private set { _parkedVehicle = value; } }

    public ParkingSpace(int row, int col, int size)
    {
        Row = row;
        Col = col;
        Size = size;
    }

    public bool ParkVehicle(Vehicle vehicle)
    {
        if (IsOccupied)
        {
            return false;
        }

        ParkedVehicle = vehicle;
        _isOccupied = true;
        return true;
    }
}
