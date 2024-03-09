namespace Creatures.BestiaryC1o4
{
    internal class Wolf : Creature
    {

        public Wolf()
        {
            Name = "Wolf";
            Type = Types.Beast;
            Size = Sizes.Medium;
            Alignment = Alignments.Unaligned;
            HitPoints = 11 + RollMultiple(8, 2);
            ArmorClass = 13;
            Speed = "40ft";
            Attributes = [12, 15, 12, 3, 12, 6];
            ChallengeLevel = "1/4";
            Experience = 50;
            Skills = "Perception +3, Stealth +4";
            Senses = "passive Perception 13";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft, one target.
Hit: 7 (2d4 + 2) piercing damage. If the target is a creature,
it must succeed on a DC 11 Strength saving throw or be
knocked prone."
                ];
            Abilities = [
                @"
Keen Hearing and Smell. The wolf has advantage on Wisdom
(Perception) checks that rely on hearing or smell.",
                @"
Pack Tactics. The wolf has advantage on attack rolls against a
creature if at least one of the wolf's allies is within 5 feet of the
creature and the ally isn't incapacitated."
                ];
        }
    }
}
