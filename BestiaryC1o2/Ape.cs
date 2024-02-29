using Creatures.Main;

namespace Creatures.BestiaryC1o2
{
    internal class Ape : Creatures
    {
        readonly Dices dice = new();
        public Ape()
        {
            Name = "Ape";
            Type = ba;
            Size = h;
            Alignment = ud;
            HitPoints = 19 + dice.RollMultiple(8, 3) + 6;
            ArmorClass = 12;
            Speed = "30ft, climb 30ft";
            Attributes = [16, 14, 14, 6, 12, 7];
            ChallengeLevel = "1/2";
            Experience = 100;
            Skills = "Athletics +5, Perception +3";
            Senses = "passive Perception 13";
            Actions = [
                @"
Multiattack. The ape makes two fist attacks.",
                @"
Fist. Melee Weapon Attack: +5 to hit, reach 5 ft., one target. Hit:
6 (1d6 + 3) bludgeoning damage.",
                @"
Rock. Ranged Weapon Attack: +5 to hit, range 25/50 ft., one
target. Hit: 6 (1d6 + 3) bludgeoning damage."
                ];
        }
    }
}
