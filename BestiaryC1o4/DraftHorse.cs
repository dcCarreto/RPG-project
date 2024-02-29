using Creatures.Main;

namespace Creatures.BestiaryC1o4
{
    internal class DraftHorse : Creatures
    {
        readonly Dices dice = new();
        public DraftHorse()
        {
            Name = "Draft Horse";
            Type = ba;
            Size = l;
            Alignment = ud;
            HitPoints = 19 + dice.RollMultiple(10, 3) + 3;
            ArmorClass = 10;
            Speed = "40ft";
            Attributes = [18, 10, 12, 2, 11, 7];
            ChallengeLevel = "1/4";
            Experience = 50;
            Senses = "passive Perception 10";
            Actions = [
                @"
Hooves. Melee Weapon Attack: +6 to hit, reach 5 ft, one target.
Hit: 9 (2d4 + 4) bludgeoning damage."
                ];
        }
    }
}
