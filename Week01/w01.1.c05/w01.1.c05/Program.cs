Console.WriteLine("What is the temperature of the water? (Celsius)");
double temp = Convert.ToDouble(Console.ReadLine());
if (temp <= 0)
{
    Console.WriteLine("At " + temp + " degrees Celsius, the water will be solid");
}
else if ((temp > 0) && (temp < 100))
{
    Console.WriteLine("At " + temp + " degrees Celsius, the water will be liquid");
}
else if (temp >= 100)
{
    Console.WriteLine("At " + temp + " degrees Celsius, the water will be gas");
}
else
{
    Console.WriteLine("Invalid temperature");
}