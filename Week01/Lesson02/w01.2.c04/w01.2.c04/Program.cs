string pinCode = "1234";

for (int i = 3; i >= 0; i--)
{
    Console.WriteLine("Enter your PIN");
    Console.WriteLine(i + " attempts left");
    string attempt = Console.ReadLine();
    if (attempt == pinCode)
    {
        Console.WriteLine("Correct!");
        break;
    }
    else if (attempt != pinCode && i == 1)
    {
        Console.WriteLine("Your pass is confiscated.");
        break;
    }
}