using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a dictionary to store contact information
        var contacts = new Dictionary<string, string>();


        // Prompt the user for input and perform the requested operation
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Enter a command (add, view, remove, list, quit):");
            string command = Console.ReadLine();

            if (command == "add")
            {
                Console.WriteLine("Enter the name: ");
                var name = Console.ReadLine();
                Console.WriteLine("Enter the phone number: ");
                var phone = Console.ReadLine();
                contacts.Add(name, phone);
            }
            else if (command == "view")
            {
                Console.WriteLine("Enter the name: ");
                var search = Console.ReadLine();
                
                if (contacts.ContainsKey(search))  
                {
                    Console.WriteLine("Phone number: " + contacts[search]);
                }
                else Console.WriteLine("Contact not found");

            }
            else if (command == "remove")
            {
                Console.WriteLine("Enter the name: ");
                var toRemove = Console.ReadLine();
                if (contacts.ContainsKey(toRemove))
                {
                    contacts.Remove(toRemove);
                    Console.WriteLine("Contact was successfully removed.");
                }
                else Console.WriteLine("Contact not found");
            }
            else if (command == "list")
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact.Key + ": " + contact.Value);
                }
            }
            else if (command == "quit")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }
        }
    }
}