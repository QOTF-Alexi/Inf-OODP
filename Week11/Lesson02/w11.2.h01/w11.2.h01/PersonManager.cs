public static class PersonManager
{
    public static void SortAndDisplayPersonsByAge(Person[,] people)
    {
        // Get the number of rows and columns in the 2D array
        int numRows = people.GetLength(0);
        int numColumns = people.GetLength(1);

        // Create a 1D array by multiplying the number of rows and columns
        Person[] oneDimensionPeople = new Person[numRows * numColumns];

        // Copy elements from the 2D array to the 1D array
        int index = 0;
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numColumns; col++)
            {
                oneDimensionPeople[index] = people[row, col];
                index++;
            }
        }

        Array.Sort(oneDimensionPeople);

        foreach (Person person in oneDimensionPeople)
        {
            if (person != null) Console.WriteLine(person.ToString());
        }
    }
}