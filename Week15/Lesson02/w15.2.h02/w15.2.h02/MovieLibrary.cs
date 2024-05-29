public class MovieLibrary
{
    public Dictionary<Genre, List<Movie>> _movieDictionary;
    public MovieLibrary()
    {
        _movieDictionary = new Dictionary<Genre, List<Movie>>();

        // add all the Genres to the movieDictionary here (1).
        foreach (var genre in Enum.GetValues<Genre>())
        {
            _movieDictionary.Add(genre, new List<Movie>());
        }
    }

    public void AddMovie(Movie movie)
    {
        // implement AddMovie here (2)
        if (_movieDictionary[movie.Genre].Contains(movie)) return;
        _movieDictionary[movie.Genre].Add(movie);
    }

    public void DisplayMovies()
    {
        //Iterating through a dictionary
        foreach (KeyValuePair<Genre, List<Movie>> entry in _movieDictionary)
        {

            string key = entry.Key.ToString();
            Console.WriteLine($"Genre: {key}");

            foreach (Movie movie in entry.Value)
            {
                Console.WriteLine($"movie {movie.Name}");
            }
        }
    }
}