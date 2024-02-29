using Creatures.Main;

namespace Creatures.BestiaryC0
{
    internal class Hawk : Creatures
    {
        readonly Dices dice = new();
        public Hawk()
        {
            Name = "Hawk";
            Type = ba;
            Size = t;
            Alignment = ud;
            HitPoints = 1 + dice.Roll(4 - 1);
            Attributes = [5, 16, 8, 2, 14, 6];
            ArmorClass = 13;
            Speed = "10ft, fly 60ft";
            Experience = 10;
            ChallengeLevel = "0";
            Skills = "Perception +4";
            Senses = "passive Perception 14";
            Actions = [
                @"
Talons. Melee Weapon Attack: +5 to hit, reach 5 ft., one target.
Hit: 1 slashing damage."
            ];
            Abilities = [
                @"
Keen Sight. The hawk has advantage on Wisdom (Perception) checks that rely on sight."
             ];
        }
    }
}