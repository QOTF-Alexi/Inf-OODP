using Newtonsoft.Json;

class Program
{
    public static List<Book> BookList = null;
    
    public static void Main(string[] args)
    {
        string fileName = @"books.json";
        StreamReader reader = null;

        try
        {
            reader = new(fileName);
            string File2Json = reader.ReadToEnd();
            BookList = JsonConvert.DeserializeObject<List<Book>>(File2Json)!;
            reader.Close();


        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Missing JSON file. " + ex.Message);
            BookList = new();
            reader?.Close();
        }
        catch (JsonReaderException ex)
        {
            Console.WriteLine("Invalid JSON. " + ex.Message);
            BookList = new();
            reader?.Close();
        }
        
        Console.WriteLine("Book Collection:");
        for (int i = 1; i <= BookList.Count; i++)
        {
            Console.WriteLine($"{i}. {BookList[i-1].Title} by {BookList[i-1].Author} ({BookList[i-1].PublicationYear})");
        }
            
        bool mainLoop = true;
        while (mainLoop)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("+: add a new book");
            Console.WriteLine("-: remove a book");
            Console.WriteLine("A number: see information about this book");
            Console.WriteLine("q: quit");
            string choice = Console.ReadLine().ToLower();
            var isNumeric = int.TryParse(choice, out int numChoice);
            if (isNumeric)
            {
                ViewBook(BookList, numChoice);
            }
            else
            {
                switch (choice)
                {
                    case "+":
                        AddBook(BookList);
                        break;
                    case "-":
                        RemoveBook(BookList);
                        break;
                    case "q":
                        mainLoop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
                StreamWriter writer = new(fileName);
                string List2Json = JsonConvert.SerializeObject(BookList);
                writer.Write(List2Json);
                writer.Close();
            }
        }
    }

    public static void AddBook(List<Book> bookList)
    {
        Console.WriteLine("Enter the title of the new book:"); 
        string bookTitle = Console.ReadLine();
        Console.WriteLine("Enter the author of the new book:");
        string author = Console.ReadLine();
        Console.WriteLine("Enter the publication year of the new book:");
        try
        {
            int publicationYear = Convert.ToInt32(Console.ReadLine());
            bookList.Add(new Book(bookTitle, author, publicationYear));
        }
        catch (FormatException)
        {
            Console.WriteLine("Year is not in a valid format.");
        }
    }

    public static void RemoveBook(List<Book> bookList)
    {
        try
        {
            Console.WriteLine("Enter the number of the book to remove:");
            int toRemove = Convert.ToInt32(Console.ReadLine());
            bookList.Remove(bookList[toRemove - 1]);
            Console.WriteLine("Book removed.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Book does not exist.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Book does not exist.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Not an index.");
        }
    }

    public static void ViewBook(List<Book> bookList, int entry)
    {
        try
        {
            Console.WriteLine("Title: " + bookList[entry - 1].Title);
            Console.WriteLine("Author: " + bookList[entry - 1].Author);
            Console.WriteLine("Publication Year: " + bookList[entry - 1].PublicationYear);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Book does not exist.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Book does not exist.");
        }
    }
}