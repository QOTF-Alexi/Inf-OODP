class Fighter
{
    public string Name { get; }
    private int _maxHitPoints;
    public virtual int MaxHitPoints
    {
        get => _maxHitPoints;
        protected set => _maxHitPoints = Math.Max(value, 1);
    }
    private int _currentHitPoints;
    public int CurrentHitPoints
    {
        get => _currentHitPoints;
        protected set => _currentHitPoints = Math.Clamp(value, 0, MaxHitPoints);
    }

    public bool IsDead => CurrentHitPoints <= 0;

    public virtual int AttackPower => 10;

    public Fighter(string name)
    {
        Name = name;
        MaxHitPoints = 100;
        CurrentHitPoints = MaxHitPoints;
    }

    public void RegainHealth(int amount)
    {
        if (amount < 0)
            throw new ArgumentException(
                $"Invalid amount: {amount}. Health recovered must be non-negative.");
        CurrentHitPoints += amount;
    }
}
