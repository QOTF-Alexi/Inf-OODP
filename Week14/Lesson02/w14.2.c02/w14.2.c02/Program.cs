string[] persons = { "Dave", "John", "Peter", "Johanna", "Bart", "Henk", "Marie" };
string[] students = { "Dave", "Michael", "Roxanne", "Johanna", "John", "Bart", "Henk" };

// List of names that occur in both datasets
var commonNames = persons.Intersect(students).Distinct();

// Print the common names
Console.WriteLine("These names are in both datasets:");
foreach (var name in commonNames)
{
    Console.WriteLine(name);
}


// List of all distinct names from both datasets, in alphabetical order
var allNames = persons.Union(students).Distinct();

// Print the distinct names
Console.WriteLine("\nThese names are unique:");
foreach (var name in allNames.OrderBy(n => n))
{
    Console.WriteLine(name);
}