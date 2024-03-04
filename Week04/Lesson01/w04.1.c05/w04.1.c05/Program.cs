using Newtonsoft.Json;

class Program
{
    public static void Main(string[] args)
    {
        string fileName = @"People.json";
        StreamReader reader = new(fileName);
        string File2Json = reader.ReadToEnd();
        List<Person> listOfObjects = JsonConvert.DeserializeObject<List<Person>>(File2Json)!;
        reader.Close();

        foreach (Person p in listOfObjects)
        {
            foreach (Car c in p.OwnedCars)
            {
                for (int i = 0; i < 5; i++)
                {
                    c.Drive();
                }
            }
        }
        
        StreamWriter writer = new(fileName);
        string List2Json = JsonConvert.SerializeObject(listOfObjects);
        writer.Write(List2Json);
        writer.Close();
    }
}