public class Program
{
    public static void Main(string[] args)
    {
        switch (args[1])
        {
            case "Operator": TestOperatorOverloadingEquals(); return;
            case "IEquatable": TestIEquatable(); return;
            case "Equals": TestEquals(); return;
            case "EqualsObj": TestEqualsObj(); return;
            default: throw new ArgumentException();
        }
    }

    public static void TestOperatorOverloadingEquals()
    {
        var objects = new object[]
        {
            new Person { Name = "Max", Age = 5 },
            new Person { Name = "Max", Age = 5 },
            new Person { Name = "May", Age = 25 },
            new Student { Name = "May", Age = 25, StudentId = "01234" },
            new Dog { Name = "Max", Age = 5 },
            null,
            null,
        };

        Person p1 = new Person { Name = "Max", Age = 5 };
        Person p2 = new Person { Name = "Max", Age = 5 };
        Person p3 = new Person { Name = "May", Age = 25 };
        Person p4 = new Person { Name = "May", Age = 25 };
        Person p5 = null;
        Person p6 = null;
        Student s1 = new Student { Name = "May", Age = 25, StudentId = "01234" };

        Console.WriteLine($"p1 and p2 are equal: " + (p1 == p2));
        Console.WriteLine($"p1 and p3 are equal: " + (p1 == p3));
        Console.WriteLine($"p3 and p4 are equal: " + (p3 == p4));
        Console.WriteLine($"p2 and p5 are equal: " + (p2 == p5));
        Console.WriteLine($"p6 and p1 are equal: " + (p6 == p1));
        Console.WriteLine($"p5 and p6 are equal: " + (p5 == p6));
        Console.WriteLine($"p3 and s1 are equal: " + (p3 == s1));

        Console.WriteLine();

        Console.WriteLine($"p1 and p2 are not equal: " + (p1 != p2));
        Console.WriteLine($"p1 and p3 are not equal: " + (p1 != p3));
        Console.WriteLine($"p3 and p4 are not equal: " + (p3 != p4));
        Console.WriteLine($"p2 and p5 are not equal: " + (p2 != p5));
        Console.WriteLine($"p6 and p1 are not equal: " + (p6 != p1));
        Console.WriteLine($"p5 and p6 are not equal: " + (p5 != p6));
        Console.WriteLine($"p3 and s1 are not equal: " + (p3 != s1));
    }

    public static void TestIEquatable()
    {
        Type personType = typeof(Person);
        Type equatableType = typeof(IEquatable<>).MakeGenericType(personType);
        bool implementsEquatable = equatableType.IsAssignableFrom(personType);

        Console.WriteLine("Person implements IEquatable<Person>: " + implementsEquatable);
    }

    public static void TestEquals()
    {
        var people = new Person[] {
            new Person { Name = "John", Age = 30 },
            new Person { Name = "John", Age = 30 },
            new Person { Name = "John", Age = 25 },
            new Person { Name = "Jane", Age = 30 },
        };

        for (int i = 0; i < people.Length; i++)
        {
            for (int j = i + 1; j < people.Length; j++)
            {
                Person p1 = people[i];
                Person p2 = people[j];
                Console.WriteLine(
                    $"{p1.Name} ({p1.Age}) equals {p2.Name} ({p2.Age}): {p1.Equals(p2)}");
            }
        }
    }

    public static void TestEqualsObj()
    {
        var objects = new object[]
        {
            new Person { Name = "Max", Age = 5 },
            new Person { Name = "Max", Age = 5 },
            new Person { Name = "May", Age = 25 },
            new Student { Name = "May", Age = 25, StudentId = "01234" },
            new Dog { Name = "Max", Age = 5 },
            null,
        };

        for (int i = 0; i < objects.Length; i++)
        {
            for (int j = i + 1; j < objects.Length; j++)
            {
                object o1 = objects[i];
                object o2 = objects[j];
                if (ReferenceEquals(o1, null) || ReferenceEquals(o2, null))
                {
                    Console.WriteLine("Object is null. Skipping...");
                }
                else if ((o1 is Person && o2 is Person) ||
                    (o1 is Student && o2 is Person) ||
                    (o1 is Person && o2 is Student))
                {
                    Console.WriteLine($"{o1.GetType().Name} {o1} equals {o2.GetType().Name} {o2}: {o1.Equals(o2)}");
                }
                else if (o1 is Dog || o2 is Dog)
                {
                    Console.WriteLine($"{o1.GetType().Name} {o1} does not equal {o2.GetType().Name} {o2}");
                }
            }
        }
    }
}