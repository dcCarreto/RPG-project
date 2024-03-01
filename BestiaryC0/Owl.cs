namespace Creatures.BestiaryC0
{
    internal class Owl : Creatures
    {

        public Owl()
        {
            Name = "Owl";
            Type = ba;
            Size = t;
            Alignment = ud;
            HitPoints = 1 + Roll(4) - 1;
            Attributes = [3, 13, 8, 2, 12, 7];
            ArmorClass = 11;
            Speed = "5ft, fly 60ft";
            Experience = 10;
            ChallengeLevel = "0";
            Skills = "Perception +3, Stealth +3";
            Senses = "darkvision 120ft, passive Perception 13";
            Actions = [
                @"
Talons. Melee Weapon Attack: +3 to hit, reach 5 ft., one target. Hit: 1 slashing damage."
            ];
            Abilities = [
                @"
Flyby. The owl doesn't provoke opportunity attacks when it flies out of an enemy's reach.",
                @"
Keen Hearing and Sight. The owl has advantage on Wisdom (Perception) checks that rely on hearing or sight."
            ];
        }
    }
}