using Newtonsoft.Json;

public static class Calculator
{
    public static string FileName = "Memory.json";
    
    public static double Add(double Summand1, double Summand2)
    {
        return Summand1 + Summand2;
    }
    
    public static double Subtract(double Summand1, double Summand2)
    {
        return Summand1 - Summand2;
    }
    
    public static double Multiply(double Summand1, double Summand2)
    {
        return Summand1 * Summand2;
    }
    
    public static double Divide(double Summand1, double Summand2)
    {
        return Summand1 / Summand2;
    }
    
    public static double Modulo(double Summand1, double Summand2)
    {
        return Summand1 % Summand2;
    }

    public static void StoreInMemory(double valueToWrite)
    {
        StreamWriter writer = new StreamWriter(FileName); //fileName is "Memory.json"
        writer.Write(JsonConvert.SerializeObject(valueToWrite));
        writer.Close();
    }

    public static double RestoreFromMemory()
    {
        StreamReader reader = new StreamReader(FileName); //fileName is "Memory.json"
        string jsonString = reader.ReadToEnd();
        reader.Close();
        return JsonConvert.DeserializeObject<double>(jsonString)!;
    }
}