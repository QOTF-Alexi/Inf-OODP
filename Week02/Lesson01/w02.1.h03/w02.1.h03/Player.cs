public class Player
{
    public string Name;
    public int Power;
    public int HealthPoints;
    
    public Player(string Name, int Power)
    {
        this.Name = Name;
        this.Power = Power;
        HealthPoints = 100;
    }

    public void TakeDamage(int Power)
    {
        if (HealthPoints - Power > 0)
        {
            HealthPoints -= Power;
        }
        else HealthPoints = 0;
    }

    public bool IsAlive()
    {
        if (HealthPoints <= 0)
        {
            return false;
        }
        else return true;
    }
}