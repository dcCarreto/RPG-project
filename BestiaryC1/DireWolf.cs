namespace Creatures.BestiaryC1
{
    internal class DireWolf : CreatureAttributes
    {

        public DireWolf()
        {
            Name = "Dire Wolf";
            Type = ba;
            Size = l;
            Alignment = ud;
            HitPoints = 37 + RollMultiple(10, 5) + 10;
            ArmorClass = 14;
            Speed = "50ft";
            Attributes = [17, 15, 15, 3, 12, 7];
            ChallengeLevel = "1";
            Experience = 200;
            Skills = "Perception +5, Stealth + 4";
            Senses = "passive Perception 13";
            Actions = [
                @"
Bite. Melee Weapon Attack: +5 to hit, reach 5 ft. , one target. Hit:
10 (2d6 + 3) piercing damage. If the target is a creature, it must
succeed on a DC 13 Strength saving throw or be knocked prone."
                ];
            Abilities = [
                @"
Keen Hearing and Smell. The wolf has advantage on Wisdom
(Perception) checks that rely on hearing or smell.",
                @"
Pack Tactics. The wolf has advantage on an attack roll against a
creature if at least one of the wolf's allies is within 5 feet of the
creature and the ally isn't incapacitated."
                ];
        }
    }
}
