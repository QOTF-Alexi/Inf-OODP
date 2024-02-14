public class Song
{
    public string Title;
    public Artist Singer;
    
    public Song(string Title)
    {
        this.Title = Title;
        Singer = new Artist("Unknown");
    }

    public void SetSinger(Artist artist)
    {
        Singer = artist;
    }

    public string Info()
    {
        return $"{Title} is by {Singer.Name}";
    }
}