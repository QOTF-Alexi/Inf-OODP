using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        var fileList = new List<string>()
        {
            "OODP assignment.docx",
            "Project Presentation.pptx",
            "TODO list.xlsx",
        };

        string whichFileToDelete = fileList[0];

        Console.WriteLine("File selected to delete: " + whichFileToDelete);

        string confirm;
        do
        {
            Console.WriteLine("Really delete this file? (y/n)");
            confirm = Console.ReadLine();
        } while (confirm is not ("y" or "n"));

        if (confirm == "y")
        {
            fileList.Remove(whichFileToDelete);
            Console.WriteLine("File deleted");
        }
    }
}