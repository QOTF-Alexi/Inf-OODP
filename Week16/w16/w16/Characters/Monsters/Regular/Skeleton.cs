class Skeleton : Monster
{
    public override bool IsUndead => true;
    public override int ResistFire => -50;

    public Skeleton() : base("Skeleton", 20, 12, 0) { }

    public override void Heal(int amount) { } // Skeletons cannot be healed
}
