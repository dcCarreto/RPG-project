namespace Creatures.BestiaryC2
{
    internal class SilverDragonWyrmling : Creature
    {

        public SilverDragonWyrmling()
        {
            Name = "Silver Dragon Wyrmling";
            Type = Types.Dragon;
            Size = Sizes.Medium;
            Alignment = Alignments.LawfulGood;
            HitPoints = 45 + RollMultiple(8, 6) + 18;
            ArmorClass = 17;
            Speed = "30ft, fly 60ft";
            Attributes = [19, 10, 17, 12, 11, 15];
            ChallengeLevel = "2";
            Experience = 450;
            SavingThrows = "Dexterity +2, Constitution +5, Wisdom +2, Charisma +4";
            DamageImmunities = "cold";
            Skills = "Perception +4, Stealth +2";
            Senses = "blindsight 10ft, darkvision 60ft, passive Perception 14";
            Languages = "Draconic";
            Actions = [
                @"
Bite. Melee Weapon Attack: +6 to hit, reach 5 ft., one target.
Hit: 9 (1d10 + 4) piercing damage.",
                @"
Breath Weapons (Recharge 5-6). The dragon uses one of the
following breath weapons.",
                @"
Cold Breath. The dragon exhales an icy blast in a 15-foot cone.
Each creature in that area must make a DC 13 Constitution
saving throw, taking 18 (4d8) cold damage on a failed save,
or half as much damage on a successful one.",
                @"
Paralyzing Breath. The dragon exhales paralyzing gas in a 15·
foot cone. Each creature in that area must succeed on a DC
13 Constitution saving throw or be paralyzed for 1 minute. A
creature can repeat the saving throw at the end of each of its
turns, ending the effect on itself on a success."
                ];
        }
    }
}
