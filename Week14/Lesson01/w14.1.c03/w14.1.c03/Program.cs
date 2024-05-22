using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Create a stack of integers
        var intStack = new Stack<int>();
        
        //int to switch on
        int choice;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add integer to stack");
            Console.WriteLine("2. Remove integer from stack");
            Console.WriteLine("3. View top integer on stack");
            Console.WriteLine("4. View all integers on stack");
            Console.WriteLine("5. Exit program");
            Console.Write("Enter the number of your choice: ");
            choice = int.Parse(Console.ReadLine());

            //Create a switch statement to handle the functions from the menu
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter a number to add to the stack:");
                    intStack.Push(int.Parse(Console.ReadLine()));
                    break;
                case 2:
                    intStack.Pop();
                    break;
                case 3:
                    Console.WriteLine("Top integer on stack: " + intStack.Peek());
                    break;
                case 4:
                    Console.WriteLine("All integers on stack:");
                    foreach (int val in intStack)
                    {
                        Console.WriteLine(val);
                    }
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 5);
    }
}

