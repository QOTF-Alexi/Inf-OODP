Console.WriteLine("What is the month? 1-12");
int month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is the day? 1-31");
int day = Convert.ToInt32(Console.ReadLine());
DateTime inputDate = new DateTime(2024, month, day);
DateTime spring = new DateTime(2024, 03, 21);
DateTime summer = new DateTime(2024, 06, 21);
DateTime autumn = new DateTime(2024, 09, 21);
DateTime winter = new DateTime(2024, 12, 21);


string result = inputDate switch
{
    var x when x >= spring && x < summer => "Spring",
    var x when x >= summer && x < autumn => "Summer",
    var x when x >= autumn && x < winter => "Autumn",
    _ => "Winter"
};


Console.WriteLine($"on {day}-{month} it is {result}");