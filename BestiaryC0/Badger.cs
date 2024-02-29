using Creatures.Main;

namespace Creatures.BestiaryC0
{
    internal class Badger : Creatures
    {
        readonly Dices dice = new();
        public Badger()
        {
            Name = "Badger";
            Type = ba;
            Size = t;
            Alignment = ud;
            HitPoints = 3 + (dice.Roll(4) + 1);
            Attributes = [4, 11, 12, 2, 12, 5];
            ArmorClass = 10;
            Speed = "20ft, burrow 5ft";
            Experience = 10;
            ChallengeLevel = "0";
            Senses = "darkvision 30ft, passive Perception";
            Actions = [
                @"
Bite. Melee Weapon Attack: +2 to hit, reach 5 ft., one target. Hit: 1 piercing damage."
                ];
            Abilities = [
                @"
Keen Smell. The badger has advantage on Wisdom (Perception) checks that rely on smell.",
                ];

        }
    }
}
