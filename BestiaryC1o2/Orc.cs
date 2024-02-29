using Creatures.Main;

namespace Creatures.BestiaryC1o2
{
    internal class Orc : Creatures
    {
        readonly Dices dice = new();
        public Orc()
        {
            Name = "Orc";
            Type = hu;
            Size = m;
            Alignment = ce;
            HitPoints = 15 + dice.RollMultiple(8, 2) + 6;
            ArmorClass = 13;
            Speed = "30ft";
            Attributes = [16, 12, 16, 7, 11, 10];
            ChallengeLevel = "1/2";
            Experience = 100;
            Skills = "Intimidation +2";
            Senses = "darkvision 60ft, passive Perception 10";
            Languages = "Common, Orc";
            Actions = [
                @"
Greataxe. Melee Weapon Attack: +5 to hit, reach 5 ft., one
target. Hit: 9 (1 12 + 3) slashing damage.",
                @"
javelin. Melee or Ranged Weapon Attack: +5 to hit, reach 5 ft. or
range 30{120 ft., one target. Hit: 6 (1d6 + 3) piercing damage."
                ];
            Abilities = [
                @"
Aggressive. As a bonus action, the ore can move up to its speed
toward a hostile creature that it can see."
                ];
        }
    }
}
