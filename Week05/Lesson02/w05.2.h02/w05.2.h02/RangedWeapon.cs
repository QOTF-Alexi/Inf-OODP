public class RangedWeapon : Weapon
{
    public readonly int Range;

    public RangedWeapon(string name, int damage, int range) : base(name, damage)
    {
        Range = range;
    }
}