Console.WriteLine("Hello. Please enter your last name");
var lName = Console.ReadLine();
Console.WriteLine("What is the initial of your first name?");
var strInitial = Console.ReadLine();
char initial = Convert.ToChar(strInitial);
string output = "Welcome to the course, " + initial + " " + lName + ". We will watch your career with great interest.";
Console.WriteLine(output);
