namespace Creatures.BestiaryC1
{
    internal class CopperDragonWyrmling : Creature
    {

        public CopperDragonWyrmling()
        {
            Name = "Copper Dragon Wyrmling";
            Type = dr;
            Size = m;
            Alignment = cg;
            HitPoints = 22 + RollMultiple(8, 4) + 4;
            ArmorClass = 16;
            Speed = "30ft, climb 30ft, fly 60ft";
            Attributes = [15, 12, 13, 14, 11, 13];
            ChallengeLevel = "1";
            Experience = 200;
            SavingThrows = "Dex +3, Con +3, Wis +2, Cha +3";
            DamageImmunities = "acid";
            Skills = "Perception +4, Stealth +3";
            Senses = "blindsight 10ft, darkvision 60ft, passive Perception 14";
            Languages = "Draconic";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 7 (1d10 + 2) piercing damage.",
                @"
Breath Weapons (Recharge 5-6). The dragon uses one of the
following breath weapons.",
                @"
Acid Breath. The dragon exha les acid in an 20-foot line that
is 5 feet wide. Each creature in that line must make a DC 11
Dexterity saving throw, taking 18 (4d8) acid damage on a
failed save, or half as much damage on a successful one.",
                @"
Slowing Breath. The dragon exha les gas in a 1 5-foot cone. Each
creature in that area must succeed on a DC 11 Constitution
saving throw. On a failed save, the creature can't use
reactions, its speed is halved, and it can't make more than
one attack on its turn. In addition, the creature can use either
an action or a bonus action on its turn, but not both. These
effects last for 1 minute. The creature can repeat the saving
throw at the end of each of its turns, ending the effect on
itself with a successful save."
                ];
        }
    }
}
