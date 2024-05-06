public class ParkingLot
{
    public int[] NumColsArr { get; }
    public ParkingSpace[][] ParkingSpaces { get; }

    public ParkingLot(int[] numColsArr)
    {
        NumColsArr = numColsArr;
        ParkingSpaces = new ParkingSpace[numColsArr.Length][];

        for (int row = 0; row < numColsArr.Length; row++)
        {
            int numCols = numColsArr[row];
            ParkingSpaces[row] = new ParkingSpace[numCols];

            for (int col = 0; col < numCols; col++)
            {
                // Determine the size of ParkingSpace based on the number of rows
                int spaceSize = (numColsArr.Length > 4) ? 1 : 2;
                ParkingSpaces[row][col] = new ParkingSpace(row, col, spaceSize);
            }
        }
    }

    public bool ParkVehicle(Vehicle vehicle, ParkingSpace space)
    {
        if (space.IsOccupied)
        {
            return false;
        }

        space.ParkVehicle(vehicle);
        return true;
    }

    public ParkingSpace FindAvailableSpace(Vehicle vehicle)
    {
        foreach (var row in ParkingSpaces)
        {
            foreach (var space in row)
            {
                if (!space.IsOccupied && space.Size == vehicle.Size)
                {
                    return space;
                }
            }
        }

        return null;
    }

    public int NumCarsParked()
    {
        int count = 0;
        foreach (var row in ParkingSpaces)
        {
            count += row.Count(space => space.IsOccupied && space.Size == 1);
        }
        return count;
    }

    public int NumTrucksParked()
    {
        int count = 0;
        foreach (var row in ParkingSpaces)
        {
            count += row.Count(space => space.IsOccupied && space.Size == 2);
        }
        return count;
    }
}
