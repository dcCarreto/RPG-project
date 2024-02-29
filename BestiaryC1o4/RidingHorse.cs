using Creatures.Main;

namespace Creatures.BestiaryC1o4
{
    internal class RidingHorse : Creatures
    {
        readonly Dices dice = new();
        public RidingHorse()
        {
            Name = "Riding Horse";
            Type = ba;
            Size = l;
            Alignment = ud;
            HitPoints = 13 + dice.RollMultiple(10, 2) + 2;
            ArmorClass = 10;
            Speed = "60ft";
            Attributes = [16, 10, 12, 2, 11, 7];
            ChallengeLevel = "1/4";
            Experience = 50;
            Senses = "passive Perception 10";
            Actions = [
                @"
Hooves. Melee Weapon Attack: +2 to hit, reach 5 ft ., one target.
Hit: 8 (2d4 + 3) bludgeoning damage."
                ];
        }
    }
}
