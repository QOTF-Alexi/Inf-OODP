Console.WriteLine("What is your age?");
int userAge = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is the age of the student next to you?");
int nextAge = Convert.ToInt32(Console.ReadLine());
if (userAge == nextAge)
{
    Console.WriteLine("Your ages are equal");
}
else if (userAge > nextAge)
{
    Console.WriteLine("You are older");
}
else if (userAge < nextAge)
{
    Console.WriteLine("You are younger");
}
else
{
    Console.WriteLine("Invalid age(s)");
}
