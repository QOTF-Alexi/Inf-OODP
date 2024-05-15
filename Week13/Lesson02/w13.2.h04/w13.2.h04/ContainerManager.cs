public static class ContainerManager
{
    public static void Start(string path)
    {
        /*
         * This public static method takes a string path to the folder containing the json manifest files.
         * For every json manifest file in the folder the ProcessManifest method is called
         * (hint: you can use Directory.EnumerateFiles to retrieve all files from a file path).
         * Print the value of the ToString to the console for every container returned by the ProcessManifest method.
         */
    }

    public static List<Container> ProcessManifest(string path)
    {
        /*
         * This public static method takes a string path of a json manifest file and returns a List<Container>.
         * See code examples of Week 4 on how to read and convert a json file to objects with the Newtonsoft library.
         */
    }

    public static List<Container> SearchByOrigin(List<Container> containers, string coo)
    {
        /*
         * this public static method takes a List<Container> and a container origin as string.
         * It should call the List<T>.FindAll method, using a lambda expression, on the input list of containers and return a new list of containers.
         * The lambda expression should check for containers with an Origin matching the origin string argument of the method.
         */
    }

    public static Container SearchForHeaviest(List<Container> containers)
    {
        /*
         * this public static method takes a List<Container>.
         * It should call the List<T>.MaxBy method, using a lambda expression to return the heaviest Container from the list of containers.
         */
    }
}