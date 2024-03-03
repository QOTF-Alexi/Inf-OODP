public class Monster
{
    public readonly string Name;
    public int CurrentHP;
    public int Strength;
    public int Experience;
    
    public Monster(string name, int currenthp, int strength, int experience)
    {
        Name = name;
        CurrentHP = currenthp;
        Strength = strength;
        Experience = experience;
    }

    public void Attack(Player player)
    {
        player.TakeDamage(Strength);
    }

    public void TakeDamage(int damage)
    {
        CurrentHP -= damage;
        if (CurrentHP < 0)
        {
            CurrentHP = 0;
        }
    }

    public bool IsAlive()
    {
        return (CurrentHP > 0);
    }
}