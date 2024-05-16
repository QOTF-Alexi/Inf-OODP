using Newtonsoft.Json;

public static class ContainerManager
{
    public static void Start(string path)
    {
        /*
         * This public static method takes a string path to the folder containing the json manifest files. (DONE)
         * For every json manifest file in the folder the ProcessManifest method is called (DONE)
         * (hint: you can use Directory.EnumerateFiles to retrieve all files from a file path).
         * Print the value of the ToString to the console for every container returned by the ProcessManifest method. (DONE)
         */
        foreach (var file in Directory.EnumerateFiles(path))
        {
            foreach (var container in ProcessManifest(file))
            {
                Console.WriteLine(container.ToString());
            }
        }
    }

    public static List<Container> ProcessManifest(string path)
    {
        /*
         * This public static method takes a string path of a json manifest file and returns a List<Container>. (DONE)
         * See code examples of Week 4 on how to read and convert a json file to objects with the Newtonsoft library.
         */
        StreamReader reader = new(path);
        string fileToJson = reader.ReadToEnd();
        List<Container> containers = JsonConvert.DeserializeObject<List<Container>>(fileToJson)!;
        reader.Close();
        return containers;
    }

    public static List<Container> SearchByOrigin(List<Container> containers, string coo)
    {
        /*
         * this public static method takes a List<Container> and a container origin as string. (DONE)
         * It should call the List<T>.FindAll method, using a lambda expression, on the input list of containers and return a new list of containers. (DONE)
         * The lambda expression should check for containers with an Origin matching the origin string argument of the method. (DONE?)
         */
        return containers.FindAll(x => x.Origin == coo);
    }

    public static Container SearchForHeaviest(List<Container> containers)
    {
        /*
         * this public static method takes a List<Container>.
         * It should call the List<T>.MaxBy method, using a lambda expression to return the heaviest Container from the list of containers.
         */
        return containers.MaxBy(x => x.Weight);
    }
}