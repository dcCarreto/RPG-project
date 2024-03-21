namespace Base.BestiaryC1o4
{
    internal class Elk : Creature
    {

        public Elk()
        {
            Name = "Elk";
            Type = Types.Beast;
            Size = Sizes.Large;
            Alignment = Alignments.Unaligned;
            HitPoints = 13 + RollMultiple(10, 2) + 2;
            ArmorClass = 10;
            Speed = "50ft";
            Attributes = [16, 10, 12, 2, 10, 6];
            Senses = "passive Perception 10";
            Actions = [
                @"
Ram. Melee Weapon Attack: +5 to hit, reach 5 ft, one target.
Hit: 6 (1d6 + 3) bludgeoning damage.",
@"
Hooves. Melee Weapon Attack: +5 to hit, reach 5 ft., one prone
creature. Hit: 8 (2d4 + 3) bludgeoning damage."
                ];
            Abilities = [
                @"
Charge. If the elk moves at least 20 feet straight toward a
target and then bits it with a ram attack on the same turn, the
target takes an extra 7 (2d6) damage. If the target is a creature,
it must succeed on a DC 13 Strength saving throw or be
knocked prone."
                ];
        }
    }
}
