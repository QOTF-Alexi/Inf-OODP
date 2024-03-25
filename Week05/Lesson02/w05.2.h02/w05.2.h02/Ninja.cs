public class Ninja : Fighter
{
    public override int AttackRange { get; } = 5;

    public Ninja(string name, Weapon weapon) : base(name, weapon)
    {
    }

    public int Attack(int distance)
    {
        if (distance <= 1)
        {
            return BaseAttack + MainWeapon.Damage;
        }
        else
        {
            int attack = (BaseAttack + MainWeapon.Damage) * 4;
            MainWeapon = null;
            return attack;
        }
    }
}