namespace Creatures.BestiaryC0
{
    internal class Rat : CreatureAttributes
    {

        public Rat()
        {
            Name = "Rat";
            Type = ba;
            Size = t;
            Alignment = ud;
            HitPoints = 1 + Roll(4) - 1;
            Attributes = [2, 11, 9, 2, 10, 4];
            ArmorClass = 10;
            Speed = "20ft";
            Experience = 10;
            ChallengeLevel = "0";
            Senses = "darkvision 30ft, passive Perception 10";
            Actions = [
                @"
Bite. Melee Weapon Attack: +0 to hit, reach 5f, one target.
Hit 1 piercing damage"
];
            Abilities = [
                @"
Keen Smell. The rat has advantage on Wisdom (Perception) checks
that rely on smell."
            ];
        }
    }
}