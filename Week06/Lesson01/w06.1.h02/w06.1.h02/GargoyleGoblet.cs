class GargoyleGoblet : Familiar, ITransform
{
    public GargoyleGoblet() { }

    public bool IsTransformed { get; private set; }

    public void Transform() => IsTransformed = true;
    public void Revert() => IsTransformed = false;

    public override int Attack => IsTransformed ? 0 : base.Attack;
    public void Drink(Fighter fighter)
    {
        fighter.RegainHealth(fighter.MaxHitPoints);
        if (fighter is Witch witch)
            witch.RecoverMagicPoints(witch.MaxMagicPoints);
    }
}
