public class Card
{
    public readonly string Suit;
    public readonly string Rank;

    public Card(string suit, string rank)
    {
        Suit = suit;
        Rank = rank;
    }

    public string GetName()
    {
        return $"{Rank} of {Suit}";
    }
}