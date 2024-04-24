using System.Reflection;

public class Program
{
    static void Main(string[] args)
    {
        switch (args[1])
        {
            case "Car": TestCarMembers(); return;
            case "Tire": TestTireMembers(); return;
            case "Func": TestFunctionality(); return;
            case "Equals": TestEquals(); return;
            default: throw new ArgumentException();
        }
    }

    static void TestCarMembers()
    {
        Console.WriteLine("=== Testing Car members ===");

        string[] membersToTest = new[] { "Make", "Model", "Tires" };
        var carType = typeof(Car);
        FieldInfo[] fields = carType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        foreach (FieldInfo field in fields)
        {
            if (Array.IndexOf(membersToTest, field.Name) != -1)
            {
                Console.WriteLine($"{field.Name} is readonly: {field.IsInitOnly}");
                if (field.Name == "Tires")
                {
                    Console.Write("Tires is either an array, Tuple or ValueTuple of Tire objects: ");
                    Console.WriteLine(
                        field.FieldType == typeof(Tire[]) ||
                        field.FieldType == typeof(Tuple<Tire, Tire, Tire, Tire>) ||
                        field.FieldType == typeof((Tire, Tire, Tire, Tire))
                    );
                }
            }
        }
    }

    static void TestTireMembers()
    {
        Console.WriteLine("=== Testing Tire members ===");

        string[] membersToTest = new[] { "Brand", "Durability" };
        var tireType = typeof(Tire);
        PropertyInfo[] properties = tireType.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        foreach (PropertyInfo property in properties)
        {
            if (Array.IndexOf(membersToTest, property.Name) != -1)
            {
                Console.WriteLine($"{property.Name} can be read: {property.CanRead}");
                Console.WriteLine($"{property.Name} can be written to: {property.CanWrite}");
            }
        }
    }

    static void TestEquals()
    {
        Car car1 = new("Ford", "Mustang", "Michelin");
        Car car2 = new("Ford", "Mustang", "Bridgestone");
        Car car3 = new("Ford-Werke GmbH", "Mustang", "Michelin");
        Car car4 = null;
        Car car5 = null;

        Console.WriteLine($"car1.Equals(car2): {car1.Equals(car2)}"); //true
        Console.WriteLine($"car1.Equals(car3): {car1.Equals(car3)}"); //false
        Console.WriteLine($"car1.Equals(car4): {car1.Equals(car4)}"); //false
        Console.WriteLine($"car2.Equals(car3): {car2.Equals(car3)}"); //false
        Console.WriteLine($"car1.Equals(car4): {car1.Equals(car4)}"); //false

        Console.WriteLine();

        Console.WriteLine($"car1 == car2: {car1 == car2}"); //true
        Console.WriteLine($"car1 == car3: {car1 == car3}"); //false
        Console.WriteLine($"car1 == car4: {car1 == car4}"); //false
        Console.WriteLine($"car2 == car3: {car2 == car3}"); //false
        Console.WriteLine($"car1 == car4: {car1 == car4}"); //false
        Console.WriteLine($"car4 == car5: {car4 == car5}"); //true
    }

    static void TestFunctionality()
    {
        Console.WriteLine("=== Testing functionality ===");

        Car car = new("Toyota", "Camry", "Michelin");

        while (car.TryDrive())
            Console.WriteLine("Drove the car");
        Console.WriteLine("Could not drive car; at least one tire should be replaced");
        Console.WriteLine(car.GetTireInfo());

        for (int i = 0; i < 4; i++)
            car.ReplaceTire("Bridgestone", i);
        Console.WriteLine(car.GetTireInfo());

        car.TryDrive();
        car.ReplaceTire(new Tire("Goodyear"), 2);
        car.TryDrive();
        car.ReplaceTire(new Tire("Continental"), 1);

        while (car.TryDrive())
            Console.WriteLine("Drove the car");
        Console.WriteLine("Could not drive car; at least one tire should be replaced");
        Console.WriteLine(car.GetTireInfo());
    }
}