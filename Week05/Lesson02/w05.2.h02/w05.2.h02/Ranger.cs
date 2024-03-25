public class Ranger : Fighter
{
    public int Arrows;
    public Weapon RangerWeapon { get; private set; }
    public override int AttackRange { get; } = 10;

    public Ranger(string name, Weapon weapon) : base(name, weapon)
    {
        RangerWeapon = weapon;
    }

    public Ranger(string name, RangedWeapon rangedWeapon, int amountArrows) : base(name, rangedWeapon)
    {
        Arrows = amountArrows;
        RangerWeapon = rangedWeapon;
    }

    public override void EquipMainWeapon(Weapon weapon)
    {
        RangerWeapon = weapon;
    }

    public override int Attack()
    {
        if (RangerWeapon.GetType() == typeof(RangedWeapon) && Arrows > 0)
        {
            return BaseAttack + RangerWeapon.Damage;
        }
        else if (RangerWeapon.GetType() == typeof(Weapon))
        {
            return Convert.ToInt32((BaseAttack + RangerWeapon.Damage) * 0.75);
        }
        else return 0;
    }
}