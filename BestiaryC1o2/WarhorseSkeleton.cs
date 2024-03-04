namespace Creatures.BestiaryC1o2
{
    internal class WarhorseSkeleton : CreatureAttributes
    {

        public WarhorseSkeleton()
        {
            Name = "Warhorse Skeleton";
            Type = un;
            Size = l;
            Alignment = le;
            HitPoints = 22 + RollMultiple(10, 3) + 6;
            ArmorClass = 13;
            Speed = "60ft";
            Attributes = [18, 12, 15, 2, 8, 5];
            ChallengeLevel = "1/2";
            Experience = 100;
            DamageVulnerabilities = "bludgeoning";
            DamageImmunities = "posion";
            ConditionImmunities = "exhaustion, poisoned";
            Senses = "darkvision 60ft, passive Perception 9";
            Actions = [
                @"
Hooves. Melee Weapon Attack: +6 to hit, reach 5 ft., one target.
Hit: 11 (2d6 + 4) bludgeoning damage."
                ];

        }
    }
}
