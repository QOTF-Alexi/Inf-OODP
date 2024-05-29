public class Program
{

    static void Main(string[] args)
    {

        switch (args[1])
        {
            case "DictionaryAndEnum": TestDictionaryAndEnum(); return;
            case "Equals": TestEquals(); return;
            default: throw new ArgumentException();
        }

    }

    static void TestEquals()
    {
        Console.WriteLine("---Testing equality---");
        Movie bttf = new("Back to the Future", 1985, Genre.Action);
        Movie bttf2 = new("Back to the Future", 1985, Genre.Action);
        Movie bttf3 = new("Back to the Future Part III", 1990, Genre.Action);
        bool correct = bttf.Equals(bttf2) && bttf.Equals(bttf3) == false;
        if (correct)
        {
            Console.WriteLine("Equality test passed!");
        }
        else
        {
            Console.WriteLine("Equality test failed!");
        }
    }


    static void TestDictionaryAndEnum()
    {
        Console.WriteLine("---Testing library---");
        MovieLibrary ml = new MovieLibrary();

        ml.AddMovie(new("The Idea of You", 2024, Genre.Comedy));
        ml.AddMovie(new("Twisters", 2024, Genre.Action));
        ml.AddMovie(new("The Shawshank Redemption", 1994, Genre.Drama));
        ml.AddMovie(new("Ghostbusters: Frozen Empire", 2024, Genre.Action));
        ml.AddMovie(new("The Godfather", 1972, Genre.Drama));
        ml.AddMovie(new(" The Dark Knight", 2008, Genre.Action));

        ml.DisplayMovies();

    }
}