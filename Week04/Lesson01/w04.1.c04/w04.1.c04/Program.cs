using Newtonsoft.Json;

class Program
{
    public static void Main()
    {
        string fileName = @"Cars.json";
        StreamReader reader = new(fileName);
        string File2Json = reader.ReadToEnd();
        List<Car> listOfObjects = JsonConvert.DeserializeObject<List<Car>>(File2Json)!;
        reader.Close();
        
        foreach (Car c in listOfObjects)
        {
            for (int i = 0; i < 5; i++)
            {
                c.Drive();
            }
        }
        
        StreamWriter writer = new(fileName);
        string List2Json = JsonConvert.SerializeObject(listOfObjects);
        writer.Write(List2Json);
        writer.Close();
    }
}