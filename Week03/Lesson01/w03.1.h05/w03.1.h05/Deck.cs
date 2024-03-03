public class Deck
{
    public readonly List<Card> Cards = new List<Card>();
    public readonly bool AreJokersIncluded;

    public Deck(bool jokersIncluded)
    {
        AreJokersIncluded = jokersIncluded;
        List<string> suits = new()
        {
            "Diamonds",
            "Clubs",
            "Hearts",
            "Spades"
        };
        List<string> ranks = new()
        {
            "Ace",
            "nums",
            "Jack",
            "Queen",
            "King"
        };

        foreach (string s in suits)
        {
            foreach (string r in ranks)
            {
                if (r == "nums")
                {
                    for (int num = 2; num <= 10; num++)
                    {
                        Cards.Add(new Card(s, Convert.ToString(num)));
                    }
                }

                else
                {
                    Cards.Add(new Card(s, r));
                }
            }
        }

        if (AreJokersIncluded)
        {
            Cards.Add(new Card("Joker", "Red"));
            Cards.Add(new Card("Joker", "Black"));
        }
    }

    public IOrderedEnumerable<Card> Shuffle()
    {
        //stuff
        Random rng = new();
        var shuffledcards = Cards.OrderBy(a => rng.Next());
        return shuffledcards;
    }

    public Card Draw()
    {
        return Cards.Last();
    }
}