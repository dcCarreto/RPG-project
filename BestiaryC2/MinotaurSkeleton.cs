namespace Creatures.BestiaryC2
{
    internal class MinotaurSkeleton : Creature
    {
        public MinotaurSkeleton()
        {
            Name = "Minotaur Skeleton";
            Type = un;
            Size = l;
            Alignment = le;
            HitPoints = 67 + RollMultiple(10, 9) + 18;
            ArmorClass = 12;
            Speed = "40ft";
            Attributes = [18, 11, 15, 6, 8, 5];
            ChallengeLevel = "2";
            Experience = 450;
            DamageVulnerabilities = "bludgeoning";
            DamageImmunities = "poison";
            ConditionImmunities = "exhaustion, poisoned";
            Senses = "darkvision 60ft, passive Perception 9";
            Languages = "understands Abyssal but can`t speak";
            Actions = [
                @"
Greataxe. Melee Weapon Attack: +6 to hi t, reach 5 ft., one
target. Hit: 17 (2d12 + 4) slashing damage.",
                @"
Gore. Melee Weapon Attack: +6 to hit, reach 5 ft., one target.
Hit: 13 (2d8 + 4) piercing damage."
                ];
            Abilities = [
                @"
Charge. If the skeleton moves at least 10 feet straight toward a
target and then hits it with a gore attack on the same turn, the
target takes an extra 9 (2d8) piercing damage. If the target is a
creature, it must succeed on a DC 14 Strength saving throw or
be pushed up to 10 feet away and knocked prone."
                ];

        }
    }
}
