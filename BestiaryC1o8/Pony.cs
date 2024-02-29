using Creatures.Main;

namespace Creatures.BestiaryC1o8
{
    internal class Pony : Creatures
    {
        readonly Dices dice = new();
        public Pony()
        {
            Name = "Pony";
            Type = ba;
            Size = m;
            Alignment = ud;
            HitPoints = 11 + dice.RollMultiple(8, 2) + 2;
            Attributes = [15, 10, 13, 2, 11, 7];
            ArmorClass = 10;
            Speed = "40ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Senses = "passive Perception 10";
            Actions = [
                @"
Hooves. Melee Weapon Attack: +4 to hit, reach 5ft, one target.
Hit: 7 (2d4 + 2) bludgeoning damage."
            ];
        }
    }
}