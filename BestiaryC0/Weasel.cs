namespace Creatures.BestiaryC0
{
    internal class Weasel : Creatures
    {

        public Weasel()
        {
            Name = "Weasel";
            Type = ba;
            Size = t;
            Alignment = ud;
            HitPoints = 1 + Roll(4) - 1;
            Attributes = [3, 16, 8, 2, 12, 3];
            ArmorClass = 13;
            Speed = "30ft";
            Experience = 10;
            ChallengeLevel = "0";
            Skills = "Perception +3, Stealth +5";
            Senses = "passive Perception 13";
            Actions = [
                @"
Bite. Melee Weapon Attack: +5 to hit, reach 5 ft., one target. Hit: 1 piercing damage."
            ];
            Abilities = [
                @"
nKeen Hearing and Smell. The weasel has advantage on Wisdom  (Perception) checks that rely on hearing or smell."
            ];
        }
    }
}