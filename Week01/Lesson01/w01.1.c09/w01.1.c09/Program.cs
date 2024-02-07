Console.WriteLine("Enter an age:");
int age = Convert.ToInt32(Console.ReadLine());

string result = age switch
{
    >= 0 and <= 12 => "Age " + age + ": a child",
    >= 13 and <= 19 => "Age " + age + ": a teenager",
    >= 20 and <= 150 => "Age " + age + ": an adult",
    _ => "Age " + age + ": invalid"
};

Console.WriteLine(result);