namespace BookCollection.Tests;

[TestClass]
public class BookCollectionTest
{
    /*
        This methods runs before every test. Optionally use this to make sure every test starts with an empty state.
    */
    [TestInitialize]
    public void RemoveAllBooks()
    {
        Program.BookList.Clear();
    }

    [TestMethod]
    public void Add_Book()
    {
        Assert.IsTrue(Program.BookList.Count == 0);
        Program.AddBook(Program.BookList);
        Console.SetIn(new StringReader("The Valiant Must Fall"));
        Console.SetIn(new StringReader("Yu Aida"));
        Console.SetIn(new StringReader("2019"));
        Assert.IsTrue(Program.BookList.Count == 1);
    }

    [TestMethod]
    public void Remove_Book()
    {
        Program.AddBook(Program.BookList);
        Console.SetIn(new StringReader("The Valiant Must Fall"));
        Console.SetIn(new StringReader("Yu Aida"));
        Console.SetIn(new StringReader("2019"));
        Program.RemoveBook(Program.BookList);
        Console.SetIn(new StringReader("1"));

        Assert.IsTrue(Program.BookList.Count == 0);
    }

    [TestMethod]
    public void Remove_AllBooks()
    {
        Program.BookList.Clear();
        Assert.IsTrue(Program.BookList.Count == 0);
    }

    [TestMethod]
    public void Get_Books()
    {
        // Add three books
        Program.AddBook(Program.BookList);
        Console.SetIn(new StringReader("The Valiant Must Fall"));
        Console.SetIn(new StringReader("Yu Aida"));
        Console.SetIn(new StringReader("2019"));
        
        Program.AddBook(Program.BookList);
        Console.SetIn(new StringReader("Candy & Cigarettes"));
        Console.SetIn(new StringReader("Tomonori Inoue"));
        Console.SetIn(new StringReader("2022"));
        
        Program.AddBook(Program.BookList);
        Console.SetIn(new StringReader("The Girl In The Spider's Web"));
        Console.SetIn(new StringReader("David Lagercrantz"));
        Console.SetIn(new StringReader("2015"));

        Assert.IsTrue(Program.BookList.Count == 3);
    }

    [TestMethod]
    public void Get_Book()
    {
        // Add three books
        Program.AddBook(Program.BookList);
        Console.SetIn(new StringReader("The Valiant Must Fall"));
        Console.SetIn(new StringReader("Yu Aida"));
        Console.SetIn(new StringReader("2019"));
        
        Program.AddBook(Program.BookList);
        Console.SetIn(new StringReader("Candy & Cigarettes"));
        Console.SetIn(new StringReader("Tomonori Inoue"));
        Console.SetIn(new StringReader("2022"));
        
        Program.AddBook(Program.BookList);
        Console.SetIn(new StringReader("The Girl In The Spider's Web"));
        Console.SetIn(new StringReader("David Lagercrantz"));
        Console.SetIn(new StringReader("2015"));

        Assert.AreEqual(Program.BookList[0].Title, "The Valiant Must Fall");
        Assert.AreEqual(Program.BookList[1].Title, "Candy & Cigarettes");
    }

    [TestMethod]
    public void Set_Books()
    {
        // Create a list with three books
        List<Book> testBooks = new()
        {
            new Book("The Valiant Must Fall", "Yu Aida", 2019),
            new Book("Candy & Cigarettes", "Tomonori Inoue", 2022),
            new Book("The Girl In The Spider's Web", "David Lagercrantz", 2015)
        };

        // Set the books
        Program.BookList = testBooks;

        Assert.IsTrue(Program.BookList.Count == 3);
        Assert.AreEqual(Program.BookList[0].Title, "The Valiant Must Fall");
        Assert.AreEqual(Program.BookList[1].Title, "Candy & Cigarettes");
    }
}