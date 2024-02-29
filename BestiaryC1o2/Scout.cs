using Creatures.Main;

namespace Creatures.BestiaryC1o2
{
    internal class Scout : Creatures
    {
        readonly Dices dice = new();
        public Scout()
        {
            Name = "Scout";
            Type = hu;
            Size = m;
            Alignment = aa;
            HitPoints = 16 + dice.RollMultiple(8, 3) + 3;
            ArmorClass = 13;
            Speed = "30ft";
            Attributes = [11, 14, 12, 11, 13, 11];
            ChallengeLevel = "1/2";
            Experience = 100;
            Skills = "Nature +4, Perception +5, Stealth +6, Survival +5";
            Senses = "passive PErception 15";
            Languages = "any one language (usually Common)";
            Actions = [
                @"
Multiattack. The scout makes two melee attacks or two
ranged attacks.",
                @"
Shortsword. Melee Weapon Attack: +4 to hit, reach 5 ft., one
target. Hit: 5 (1d6 + 2) piercing damage.",
                @"
Longbow. Ranged Weapon Attack: +4 to hi t, ranged
150/600 ft. , one target. Hit: 6 (1d8 + 2) piercing damage."
            ];
            Abilities = [
                @"
Keen Hearing and Sight. The sco ut has advantage on Wisdom
(Perception) checks that rely on hearing or sight."
                ];
        }
    }
}
