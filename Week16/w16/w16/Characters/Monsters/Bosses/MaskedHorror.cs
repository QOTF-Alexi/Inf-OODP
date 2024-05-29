class MaskedHorror : Monster
{
    private class Mask : Monster
    {
        public override bool IsBoss => true;

        public Mask Next { get; set; }
        public DamageTypes MyDamageTypes { get; }

        public override int ResistPhysical => MyDamageTypes == DamageTypes.Physical ? 100 : 0;
        public override int ResistFire => MyDamageTypes == DamageTypes.Fire ? 100 : 0;
        public override int ResistCold => MyDamageTypes == DamageTypes.Cold ? 100 : 0;
        public override int ResistLightning => MyDamageTypes == DamageTypes.Lightning ? 100 : 0;

        public Mask(string name, int maxHP, int attackPower, int defense,
            DamageTypes damageType, Mask next)
            : base(name, maxHP, attackPower, defense)
        {
            MyDamageTypes = damageType;
            Next = next;
        }
    }

    public override bool IsBoss => true;
    private Mask _currMask;

    public override int ResistPhysical => 100;
    public override int ResistFire => 100;
    public override int ResistCold => 100;
    public override int ResistLightning => 100;

    public MaskedHorror() : base("Masked Horror", 9999, 0, 999)
    {
        Mask zapMask = new Mask("Zap Mask", 100, 10, 10, DamageTypes.Lightning, null);
        Mask shiverMask = new Mask("Shiver Mask", 100, 10, 10, DamageTypes.Cold, zapMask);
        Mask burnMask = new Mask("Burning Mask", 100, 10, 10, DamageTypes.Fire, shiverMask);
        Mask stoneMask = new Mask("Stone Mask", 100, 10, 10, DamageTypes.Physical, burnMask);
        zapMask.Next = stoneMask;
        _currMask = stoneMask;

        MaxHP = stoneMask.MaxHP + burnMask.MaxHP + shiverMask.MaxHP + zapMask.MaxHP;
        CurrHP = MaxHP;
    }

    public override void Attack(ITargetable target)
    {
        Attack(new ITargetable[] { target });
    }
    public void Attack(ITargetable[] targets)
    {
        if (CurrHP <= 0)
            return;

        SpellTypes spellType = _currMask.MyDamageTypes switch
        {
            DamageTypes.Physical => SpellTypes.EarthSlide,
            DamageTypes.Fire => SpellTypes.Meteor,
            DamageTypes.Cold => SpellTypes.Blizzard,
            DamageTypes.Lightning => SpellTypes.Vortex,
            _ => throw new InvalidOperationException("Unexpected DamageTypes value")
        };
        Spell? spell = SpellFactory.GetSpell(spellType);
        spell?.CastMe(this, targets);

        bool switched = SwitchToNextMask();
        if (switched)
        {
            Console.WriteLine($"{Name} switches to {_currMask.Name}");
        }
    }

    public override int TakeDamage(Damage damage, ITargetable damageSource)
    {
        if (!IsAlive)
            return 0;

        int currMaskHP = _currMask.CurrHP;
        int damageTaken = _currMask.TakeDamage(damage, damageSource);
        CurrHP -= Math.Min(currMaskHP, damageTaken);

        if (damage.Type != _currMask.MyDamageTypes && IsAlive)
        {
            Mask prevMask = _currMask;
            SwitchToElementalMask(damage.Type);
            if (prevMask != _currMask)
                Console.WriteLine($"{Name} switches to {_currMask.Name}");
        }
        return damageTaken;
    }

    private bool SwitchToNextMask()
    {
        Mask oldMask = _currMask;
        Mask nextMask = _currMask.Next;

        // Skip defeated masks
        while (nextMask != null && nextMask.CurrHP <= 0)
        {
            nextMask = nextMask.Next;
        }

        _currMask = nextMask;
        return _currMask != oldMask;
    }

    private bool SwitchToElementalMask(DamageTypes damageType)
    {
        Mask? nextMask = FindElementalMask(_currMask, damageType);

        if (nextMask is not null && nextMask.CurrHP > 0)
        {
            _currMask = nextMask;
        }
        return nextMask is not null;
    }

    private Mask? FindElementalMask(Mask currentMask, DamageTypes targetDamageTypes)
    {
    
    }
}
