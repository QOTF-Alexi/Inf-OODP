public class Fighter
{
    public string Name;
    private int _hp;
    public int HP
    {
        get => _hp;
        private set => _hp = value >= 0 ? value : 0;
    }
    public bool IsAlive { get => HP > 0; }
    public int AttackRange { get; } = 1;
    public int BaseAttack { get; } = 5;
    public Weapon MainWeapon { get; private set; }

    public Fighter(string name, Weapon weapon)
        : this(name, weapon, 100) { }
    public Fighter(string name, Weapon weapon, int hp)
    {
        Name = name;
        EquipMainWeapon(weapon);
        HP = hp;
    }

    public virtual void EquipMainWeapon(Weapon weapon)
    {
        MainWeapon = weapon;
    }

    public virtual int Attack() => BaseAttack + (MainWeapon is null ? 0 : MainWeapon.Damage);
    public void TakeDamage(int amount) => HP -= amount;
    public override string ToString() => $"{Name} has {HP} left";
}