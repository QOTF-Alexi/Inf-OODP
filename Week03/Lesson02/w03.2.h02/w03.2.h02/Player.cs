public class Player
{
    public const string Name = "Simon Belmont";
    public int CurrentHP;
    public int MaxHP;
    public int Strength;
    public static int Experience = 0;
    public int Level = 1;
    
    public Player(int maxhp, int strength)
    {
        Experience = Player.Experience; // needs to change to whatever previous exp was.
        MaxHP = maxhp;
        CurrentHP = maxhp;
        Strength = strength;
        GetLevel();
    }

    public void Attack(Monster monster)
    {
        monster.TakeDamage(Strength);
        if (!monster.IsAlive())
        {
            Experience += monster.Experience;
        }
    }

    public void TakeDamage(int damage)
    {
        CurrentHP -= damage - Strength / 4;
        if (CurrentHP < 0)
        {
            CurrentHP = 0;
        }
    }

    public bool IsAlive()
    {
        return (CurrentHP > 0);
    }

    public int GetLevel()
    {
        if (Experience % 10 == 0 && Experience % Level != 0)
        {
            Level += 1;
            MaxHP += 10;
            Strength += 3;
        }
        return Level;
    }
}