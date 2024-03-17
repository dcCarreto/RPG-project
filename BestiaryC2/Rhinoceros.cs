namespace Creatures.BestiaryC2
{
    internal class Rhinoceros : Creature
    {
        public Rhinoceros()
        {
            Name = "Rhynoceros";
            Type = Types.Beast;
            Size = Sizes.Large;
            Alignment = Alignments.Unaligned;
            HitPoints = 45 + RollMultiple(10, 6) + 12;
            ArmorClass = 12;
            Speed = "40ft";
            Attributes = [21, 8, 15, 2, 12, 6];
            ChallengeLevel = "2";
            Experience = 450;
            Senses = "passive Perception 11";
            Actions = [
                @"
Gore. Melee Weapon Attack: +7 to hit, reach 5 ft., one target.
Hit: 14 (2d8 + 5) bludgeoning damage."
                ];
            Abilities = [
                @"
Charge. If the rhinoceros moves at least 20 feet straight toward
a target and then hits it with a gore attack on the same turn,
the target takes an extra 9 (2d8) bludgeoning damage. If the
target is a creature, it must succeed on a DC 15 Strength saving
throw or be knocked prone."
                ];
        }
    }
}
