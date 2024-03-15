public class Ranger : Fighter
{
    public int Arrows;
    
    public Ranger(string name, Weapon weapon) : base(name, weapon)
    {

    }

    public Ranger(string name, RangedWeapon rangedWeapon, int amountArrows) : base(name, rangedWeapon)
    {
        Arrows = amountArrows;
    }

    public override int Attack()
    {
        if (MainWeapon.GetType() == typeof(RangedWeapon) && Arrows > 0)
        {
            return BaseAttack + MainWeapon.Damage;
        }
        else if (MainWeapon.GetType() == typeof(Weapon))
        {
            return Convert.ToInt32((BaseAttack + MainWeapon.Damage) * 0.75);
        }
        else return 0;
    }
}