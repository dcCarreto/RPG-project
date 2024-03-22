using Base;

namespace BestiaryIndex.BestiaryC1o4
{
    internal class GiantPoisonousSnake : Creature
    {

        public GiantPoisonousSnake()
        {
            Name = "Giant Poisonous Snake";
            Type = Types.Beast;
            Size = Sizes.Medium;
            Alignment = Alignments.Unaligned;
            HitPoints = 11 + RollMultiple(8, 2) + 2;
            ArmorClass = 14;
            Speed = "30ft, swim 30ft";
            AttributeValue = [10, 18, 13, 2, 10, 3];
            ChallengeLevel = "1/4";
            Experience = 50;
            Skills = "Perception +2";
            Senses = "blindsight 10ft, passive Perception 12";
            Actions = [
                @"
Bite. Melee Weapon Attack: +6 to hit, reach 10ft., one target.
Hit: 6 (1d4 + 4) piercing damage, and the target must make
a DC 11 Constitution saving throw, taking 10 (3d6) poison
damage on a failed save, or half as much damage on a
successful one."
                ];
        }
    }
}
