using System.Reflection;

static class Program
{
    static void Main(string[] args)
    {
        switch (args[1])
        {
            case "Encapsulation": TestEncapsulation(); break;
            case "Interfaces": TestInterfaces(); break;
            case "Functionality": TestFunctionality(); break;
            default: throw new ArgumentException();
        }
    }

    public static void TestEncapsulation()
    {
        // CurrentConditionsDisplay
        string className = "CurrentConditionsDisplay";
        string fieldName = "_temperature";
        Console.WriteLine($"Class {className}");
        Console.WriteLine($" - Field {fieldName} encapsulation: "
            + TestAccessModifierField(className, fieldName, "Private"));
        fieldName = "_humidity";
        Console.WriteLine($" - Field {fieldName} encapsulation: "
            + TestAccessModifierField(className, fieldName, "Private"));
        fieldName = "_observable";
        Console.WriteLine($" - Field {fieldName} encapsulation: "
            + TestAccessModifierField(className, fieldName, "Private"));

        // StatisticsDisplay
        className = "StatisticsDisplay";
        fieldName = "_minTemperature";
        Console.WriteLine($"\nClass {className}");
        Console.WriteLine($" - Field {fieldName} encapsulation: "
            + TestAccessModifierField(className, fieldName, "Private"));
        fieldName = "_maxTemperature";
        Console.WriteLine($" - Field {fieldName} encapsulation: "
            + TestAccessModifierField(className, fieldName, "Private"));
        fieldName = "_observable";
        Console.WriteLine($" - Field {fieldName} encapsulation: "
            + TestAccessModifierField(className, fieldName, "Private"));

        // WeatherData
        className = "WeatherData";
        fieldName = "_observers";
        Console.WriteLine($"\nClass {className}");
        Console.WriteLine($" - Field {fieldName} encapsulation: "
            + TestAccessModifierField(className, fieldName, "Private"));
    }

    public static void TestInterfaces()
    {
        // Display
        Type interfaceType = typeof(IDisplay);
        Type conditionsType = typeof(CurrentConditionsDisplay);
        Type statisticsType = typeof(StatisticsDisplay);

        Console.WriteLine($"=== {interfaceType.Name} ===");
        Console.WriteLine("Is an interface: " + interfaceType.IsInterface);
        Console.WriteLine("Is implemented by CurrentConditionsDisplay: "
            + interfaceType.IsAssignableFrom(conditionsType));
        Console.WriteLine("Is implemented by StatisticsDisplay: "
            + interfaceType.IsAssignableFrom(statisticsType));
        Console.WriteLine("Method Display has the correct return and parameter types: "
            + CheckMethodSignature(interfaceType, "Display", typeof(void)));

        // IObservable
        interfaceType = typeof(IObservable);
        Type weatherType = typeof(WeatherData);
        Console.WriteLine($"\n=== {interfaceType.Name} ===");
        Console.WriteLine("Is an interface: " + typeof(IObservable).IsInterface);
        Console.WriteLine("Is implemented by WeatherData: "
            + interfaceType.IsAssignableFrom(weatherType));

        Console.WriteLine("Method RegisterObserver has the correct return and parameter types: "
            + CheckMethodSignature(interfaceType, "RegisterObserver", typeof(void), [typeof(IObserver)]));
        Console.WriteLine("Method RemoveObserver has the correct return and parameter types: "
            + CheckMethodSignature(interfaceType, "RemoveObserver", typeof(void), [typeof(IObserver)]));
        Console.WriteLine("Method NotifyObservers has the correct return and parameter types: "
            + CheckMethodSignature(interfaceType, "NotifyObservers", typeof(void)));

        // IObserver
        interfaceType = typeof(IObserver);

        Console.WriteLine($"\n=== {interfaceType.Name} ===");
        Console.WriteLine("Is an interface: " + interfaceType.IsInterface);
        Console.WriteLine("Is implemented by CurrentConditionsDisplay: "
            + interfaceType.IsAssignableFrom(conditionsType));
        Console.WriteLine("Is implemented by StatisticsDisplay: "
            + interfaceType.IsAssignableFrom(statisticsType));
        Console.WriteLine("Method Update has the correct return and parameter types: "
            + CheckMethodSignature(interfaceType, "Update", typeof(void)));
    }

    public static void TestFunctionality()
    {
        WeatherData weatherData = new();
        CurrentConditionsDisplay currentDisplay = new(weatherData);
        weatherData.RegisterObserver(currentDisplay);
        Console.WriteLine("Adding first set of measurements...");
        weatherData.SetMeasurements(20, 65, 30.4);
        weatherData.SetMeasurements(22, 70, 29.2);
        weatherData.SetMeasurements(18, 90, 29.4);

        Console.WriteLine("\nAdding second set of measurements...");
        StatisticsDisplay statisticsDisplay = new(weatherData);
        weatherData.RegisterObserver(statisticsDisplay);
        weatherData.SetMeasurements(15, 70, 29.0);
        weatherData.SetMeasurements(20, 68, 28.7);
        weatherData.SetMeasurements(13, 67, 27.9);

        foreach (IObserver observer in new List<IObserver>() { currentDisplay, statisticsDisplay })
        {
            observer.Update();
        }

        foreach (IDisplay display in new List<IDisplay>() { currentDisplay, statisticsDisplay })
        {
            display.Display();
        }
    }

    private static bool CheckMethodSignature(Type interfaceType, string methodName, Type expectedReturnType, params Type[] expectedParameterTypes)
    {
        var method = interfaceType.GetMethod(methodName);

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

        bool flag;
        switch (modifier)
        {
            case "Public":
                flag = fieldInfo.IsPublic;
                break;
            case "Private":
                flag = fieldInfo.IsPrivate;
                break;
            default:
                flag = false;
                break;
        }

        return flag ? "Correct!" : "Incorrect.";
    }
}
