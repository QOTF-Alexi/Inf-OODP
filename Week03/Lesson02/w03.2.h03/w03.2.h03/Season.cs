public class Season
{
    public readonly int Year;
    public List<Race> Races;
    public List<Team> Teams;
    public List<Driver> Drivers = new();

    public Season(int year, List<Race> races, List<Team> teams)
    {
        Year = year;
        Races = races;
        Teams = teams;

        foreach (Team t in Teams)
        {
            foreach (Driver d in t.Drivers)
            {
                Drivers.Add(d);
            }
        }
    }

    public void RunSeason()
    {
        Random randomiser = new();
        foreach (Race r in Races)
        {
            foreach (var d in Drivers)
            {
                r.Outcome.Add(Drivers[randomiser.Next(Drivers.Count)]);
            }
        }
    }

    public void SeasonResults()
    {
        foreach (Race r in Races)
        {
            Driver winner = r.Outcome[0];
            Team winnerTeam = null;
            foreach (Team t in Teams)
            {
                if (t.Drivers.Contains(winner))
                {
                    winnerTeam = t;
                }
            }
            Console.WriteLine($"{winner.Name} of {winnerTeam.Name} has won the {r.Name} Grand Prix!");

            r.Outcome[0].Score += 25;
            r.Outcome[1].Score += 18;
            r.Outcome[2].Score += 15;
            r.Outcome[3].Score += 12;
            r.Outcome[4].Score += 10;
            r.Outcome[5].Score += 8;
            r.Outcome[6].Score += 6;
            r.Outcome[7].Score += 4;
            r.Outcome[8].Score += 2;
            r.Outcome[9].Score += 1;
        }

        Console.WriteLine("Season results:");
    }
}