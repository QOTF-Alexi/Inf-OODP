using System.Reflection;

static class Program
{
    static void Main(string[] args)
    {
        switch (args[1])
        {
            case "Encapsulation": TestEncapsulation(); return;
            case "Interface": TestInterface(); return;
            case "Abstract": TestAbstract(); return;
            case "Functionality": TestFunctionality(); return;
            default: throw new ArgumentException();
        }
    }

    public static void TestEncapsulation()
    {
        string fieldName = "_documents";
        string className = "DocumentCollection";
        Console.WriteLine($"Field {fieldName} encapsulation: "
            + TestAccessModifierField(className, fieldName, "Private"));
    }

    public static void TestInterface()
    {
        Type interfaceType = typeof(IDocumentVisitor);
        Type classType = typeof(DocumentVisitor);

        Console.WriteLine($"{interfaceType.Name} is an interface: " +
            interfaceType.IsInterface);

        Console.WriteLine($"{interfaceType.Name} is implemented by {classType.Name}: " +
            classType.GetInterfaces().Contains(interfaceType));

        Console.WriteLine();

        string methodName = "Visit";
        Console.WriteLine($"Method {methodName} has the correct parameter and return types:");

        foreach (Type type in new List<Type>()
        { typeof(TextDocument), typeof(ImageDocument), typeof(AudioDocument) })
        {
            Console.WriteLine($" - {type.Name}: " +
                CheckMethodSignature(interfaceType, methodName, typeof(void), type));
        }
    }

    public static void TestAbstract()
    {
        Type baseType = typeof(Document);
        Console.WriteLine($"{baseType.Name} is an abstract class: " +
            (typeof(Document).IsAbstract && !typeof(Document).IsInterface));

        Console.WriteLine($"{baseType.Name} is inherited by:");
        foreach (Type type in new List<Type>()
            { typeof(AudioDocument), typeof(ImageDocument), typeof(TextDocument) })
        {
            Console.WriteLine($" - {type.Name}: {type.IsSubclassOf(baseType)}");
        }
    }

    public static void TestFunctionality()
    {
        DocumentCollection documents = new();
        documents.AddDocument(new TextDocument("Grocery list", "2 milk; 6 eggs"));
        documents.AddDocument(new TextDocument("Lecture notes", String.Join(" ",
            "Interfaces and abstract classes can be used to",
            "design code for optimal code maintainability and reusability.")));
        documents.AddDocument(new ImageDocument("Family picture", "C:/Users/JohnDoe/family.jpg"));
        documents.AddDocument(new AudioDocument("CallRecording", 243));

        Console.WriteLine("Current documents:");
        documents.DisplayDocuments();

        List<string> documentsToSearch = new()
        {
            "Grocery list", "Lecture notes", "Family picture", "CallRecording", "Holiday picture"
        };
        foreach (var title in documentsToSearch)
        {
            Console.WriteLine($"\nSearching for documents with title '{title}': ");
            Document document = documents.FindDocument(title);
            if (document != null)
            {
                Console.WriteLine("Found: ");
                document.Accept(new DocumentVisitor());
            }
            else
            {
                Console.WriteLine("Not found.");
            }
        }
    }

    private static string TestAccessModifierField(string cls, string field, string modifier)
    {
        var targetType = Type.GetType(cls);
        var fieldInfo = targetType?.GetField(field,
            BindingFlags.NonPublic |
            BindingFlags.Public |
            BindingFlags.Instance |
            BindingFlags.Static);

        if (fieldInfo == null)
            return $"Field not found: {field}";
        var flag = modifier switch
        {
            "Public" => fieldInfo.IsPublic,
            "Private" => fieldInfo.IsPrivate,
            _ => false,
        };
        return flag ? "Correct!" : "Incorrect.";
    }

    static bool CheckMethodSignature(Type interfaceType, string methodName, Type expectedReturnType, params Type[] expectedParameterTypes)
    {
        var method = interfaceType.GetMethod(methodName, expectedParameterTypes);

        if (method == null)
        {
            Console.WriteLine($" - Method {methodName} not found in the interface.");
            return false;
        }

        if (method.ReturnType != expectedReturnType)
        {
            Console.WriteLine($" - Incorrect return type for method {methodName}. Expected: {expectedReturnType}, Actual: {method.ReturnType}");
            return false;
        }

        var parameters = method.GetParameters();
        if (parameters.Length != expectedParameterTypes.Length)
        {
            Console.WriteLine($" - Incorrect number of parameters for method {methodName}. Expected: {expectedParameterTypes.Length}, Actual: {parameters.Length}");
            return false;
        }

        for (int i = 0; i < expectedParameterTypes.Length; i++)
        {
            if (parameters[i].ParameterType != expectedParameterTypes[i])
            {
                Console.WriteLine($" - Incorrect parameter type for parameter {parameters[i].Name} in method {methodName}. Expected: {expectedParameterTypes[i]}, Actual: {parameters[i].ParameterType}");
                return false;
            }
        }

        return true;
    }

}
