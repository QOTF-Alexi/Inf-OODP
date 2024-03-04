using Newtonsoft.Json;

class Program
{
    public static void Main(string[] args)
    {
        List<Person> listOfObjects = null;
        string fileName = @"People.json";
        try
        {
            StreamReader reader = new(fileName);
            string File2Json = reader.ReadToEnd();
            listOfObjects = JsonConvert.DeserializeObject<List<Person>>(File2Json)!;
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
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Missing JSON file. " + ex.Message);
        }
        catch (JsonReaderException ex)
        {
            Console.WriteLine("Invalid JSON. " + ex.Message);
        }
    }
}