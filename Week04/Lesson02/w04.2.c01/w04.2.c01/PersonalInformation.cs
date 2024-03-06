public static class PersonalInformation
{
    public static void PrintName(string name)
    {
        Console.WriteLine(name);
    }

    public static void PrintName(string fName, string lName)
    {
        Console.WriteLine(fName + " " + lName);
    }

    public static void PrintName(char fLetter, string lName)
    {
        Console.WriteLine(fLetter + ". " + lName);
    }

    public static int IncreaseSalary(int toIncrease)
    {
        toIncrease += 100;
        return toIncrease;
    }

    public static double IncreaseSalary(int toIncrease, double percentage)
    {
        double result;
        result = toIncrease * (1 + percentage);
        return result;
    }
    
    
}