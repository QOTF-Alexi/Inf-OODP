public class Player
{
    public string Name { get; }
    public int AttackPower { get; }
    public List<Item> Inventory { get; private set; }

    public Player(string name, int attackPower)
    {
        Name = name;
        AttackPower = attackPower;
    }

    public void Attack<T>(T  target) where T : IAttackable, ILootable
    {
        Console.WriteLine($"{Name} attacks {target.GetType().Name}");
        target.IsAttacked(AttackPower);
        Inventory.Concat(target.IsLooted());
    }

    public static bool operator >(Player player1, Player player2)
    {
        return player1.AttackPower > player2.AttackPower;
    }

    public static bool operator <(Player player1, Player player2)
    {
        return player1.AttackPower < player2.AttackPower;
    }
}