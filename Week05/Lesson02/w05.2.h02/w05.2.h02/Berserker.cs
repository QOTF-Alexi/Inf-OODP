public class Berserker : Fighter
{
    public Weapon Weapon2;
    public Berserker(string name, Weapon weapon1, Weapon weapon2) : base(name, weapon1)
    {
        Weapon2 = weapon2;
    }

    public override int Attack()
    {
        if (HP - 20 > 0)
        {
            TakeDamage(20);
            return BaseAttack * 2 + (MainWeapon is null ? 0 : MainWeapon.Damage) + (Weapon2 is null ? 0 : Weapon2.Damage);
        }
        return BaseAttack + (MainWeapon is null ? 0 : MainWeapon.Damage) + (Weapon2 is null ? 0 : Weapon2.Damage);
    }
}