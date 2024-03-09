namespace Creatures.BestiaryC1o4
{
    internal class Skeleton : Creature
    {

        public Skeleton()
        {
            Name = "Skeleton";
            Type = Types.Undead;
            Size = Sizes.Medium;
            Alignment = Alignments.LawfulEvil;
            HitPoints = 13 + RollMultiple(8, 4);
            ArmorClass = 13;
            Speed = "30ft";
            Attributes = [10, 14, 15, 6, 8, 5];
            ChallengeLevel = "1/4";
            Experience = 50;
            DamageVulnerabilities = "bludgeoning";
            DamageImmunities = "poison";
            ConditionImmunities = "exhaustion, poisoned";
            Senses = "darkvision 60ft, passive Perception 9";
            Languages = "understands all languages it knew in life but can't speak";
            Actions = [
                @"
Shortsword. Melee Weapon Attack: +4 to hit, reach 5 ft., one
target. Hit: 5 (1d6 + 2) piercing damage.",
                @"
Shortbow. Ranged Weapon Attack: +4 to hit, range 80/320 ft,
one target. Hit: 5 (1d6 + 2) piercing damage."
                ];

        }
    }
}
