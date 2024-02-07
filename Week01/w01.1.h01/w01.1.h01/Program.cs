Console.WriteLine("How many seconds?");
int seconds = Convert.ToInt32(Console.ReadLine());
int hours = seconds / 3600;
seconds -= hours * 3600;
int minutes = seconds / 60;
seconds -= minutes * 60;
Console.WriteLine("Hours: " + hours + "\nMinutes: " + minutes + "\nSeconds left: " + seconds);