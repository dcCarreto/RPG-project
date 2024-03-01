namespace Creatures.BestiaryC1o2
{
    internal class RustMonster : Creatures
    {

        public RustMonster()
        {
            Name = "Rust Monster";
            Type = mo;
            Size = m;
            Alignment = ud;
            HitPoints = 27 + RollMultiple(8, 5) + 5;
            ArmorClass = 14;
            Speed = "40ft";
            Attributes = [13, 12, 13, 2, 13, 6];
            ChallengeLevel = "1/2";
            Experience = 100;
            Senses = "darkvision 60ft, passive Perception 11";
            Actions = [
                @"
Bite. Melee Weapon Attack: +3 to hit, reach 5 ft., one target.
Hit: 5 (1d8 + 1) piercing damage.",
                @"
Antennae. The rust monster corrodes a nonmagical ferrous
metal object it can see within 5 feet of it. If the object isn't
being worn or carried, the touch destroys a 1-foot cube of it. If
the object is being worn or carried by a creature, the creature
can make a DC 11 Dexterity saving throw to avoid the rust
monster's touch.
If the object touched is either metal armor or a metal shield
being worn or carried, its takes a permanent and cumulative
-1 penalty to the AC it offers. Armor reduced to an AC of 10
or a shield that drops to a +0 bonus is destroyed. If the object
touched is a held metal weapon, it rusts as described in the
Rust Metal trait."
                ];
            Abilities = [
                @"
Iron Scent. The rust monster can pinpoint, by scent, the
location offerrous metal within 30 feet of it.",
                @"
Rust Metal. Any non magical weapon made of metal that hits
the rust monster corrodes. After dealing damage, the weapon
takes a permanent and cumulative -1 penalty to damage roll s.
If its penalty drops to -5, the weapon is destroyed. Non magical
ammunition made of metal that hits the rust monster is
destroyed after dealing damage."
                ];
        }
    }
}
