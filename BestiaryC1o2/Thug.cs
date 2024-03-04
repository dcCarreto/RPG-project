namespace Creatures.BestiaryC1o2
{
    internal class Thug : CreatureAttributes
    {

        public Thug()
        {
            Name = "Thug";
            Type = hu;
            Size = m;
            Alignment = ana;
            HitPoints = 32 + RollMultiple(8, 5) + 10;
            ArmorClass = 11;
            Speed = "30ft";
            Attributes = [15, 11, 14, 10, 10, 11];
            ChallengeLevel = "1/2";
            Experience = 100;
            Skills = "Intimidation +2";
            Senses = "passive Perception 10";
            Languages = "any one languague (usually Common)";
            Actions = [
                @"
Multiattack. The thug makes two melee attacks.",
                @"
Mace. Melee Weapon Attack: +4 to hit, reach 5 ft., one creature.
Hit: 5 (1d6 + 2) bludgeoning damage.",
                @"
Heavy Crossbow. Ranged Weapon Attack: +2 to hit, range
100/400 ft., one target. Hit: 5 (1d10) piercing damage."
                ];
            Abilities = [
                @"
Pack Tactics. The thug has advantage on an attack roll against
a creature if at least one of the thug's allies is within 5 feet of
the creature and the ally is n't incapacitated."
                ];
        }
    }
}
