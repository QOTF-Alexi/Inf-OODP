Console.WriteLine("What is the temperature in Celsius?");
double celsius = Convert.ToDouble(Console.ReadLine());
double fahrenheit = celsius * 1.8 + 32;
Console.WriteLine((celsius + " C = " + fahrenheit + " F"));
Console.WriteLine(("Truncated that is " + Convert.ToInt32(Math.Truncate(fahrenheit)) + " F"));