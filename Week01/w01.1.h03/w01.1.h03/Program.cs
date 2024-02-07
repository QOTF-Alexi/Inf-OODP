int score = 0;

Console.WriteLine("Answer the following MCQs:");

Console.WriteLine("Which of the following is NOT a valid type in C#?");
Console.WriteLine("A: bool\nB: int\nC: var\nD: string");
string answer_q1 = Console.ReadLine().ToUpper();
if (answer_q1 == "C")
{
    score += 1;
}

Console.WriteLine("What happens if you execute the following line C#?");
Console.WriteLine("int x = 1.23;");
Console.WriteLine("A: x will be 1.23\nB: x will be 1\nC: x will be 1.0\nD: you will get a compiler error");
string answer_q2 = Console.ReadLine().ToUpper();
if (answer_q2 == "D")
{
    score += 1;
}

Console.WriteLine("Consider the following line:\ndouble d = 1.23;");
Console.WriteLine("What are TWO ways to convert variable d to an int?");
Console.WriteLine("A: int i = (int)d;\nB: int i = int(d)\nC: int i = 0 + d\nD: int i = Convert.ToInt32(d)");
Console.WriteLine("Your first answer:");
string answer_q3_1 = Console.ReadLine().ToUpper();
int q3CorrectCounter = 0;
if (answer_q3_1 == "A" || answer_q3_1 == "D")
{
    q3CorrectCounter += 1;
}
Console.WriteLine("Your second answer:");
string answer_q3_2 = Console.ReadLine().ToUpper();
if ((answer_q3_2 == "A" || answer_q3_2 == "D") & answer_q3_1 != answer_q3_2)
{ 
    q3CorrectCounter += 1;
}

if (q3CorrectCounter == 2)
{
    score += 1;
}

if (score == 3)
{
    Console.WriteLine("Your score: 3 out of 3. Well done!");
}
else
{
    Console.WriteLine("Your score: " + score + " out of 3");
}