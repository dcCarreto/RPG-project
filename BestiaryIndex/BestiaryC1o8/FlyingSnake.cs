using Base;

namespace BestiaryIndex.BestiaryC1o8
{
    internal class FlyingSnake : Creature
    {

        public FlyingSnake()
        {
            Name = "Flying Snake";
            Type = Types.Beast;
            Size = Sizes.Tiny;
            Alignment = Alignments.Unaligned;
            HitPoints = 5 + RollMultiple(4, 2);
            AttributeValue = [4, 18, 11, 2, 12, 5];
            ArmorClass = 14;
            Speed = "30ft, fly 60ft, swim 30ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Senses = "blindsight 10ft, passive Perception 11";
            Actions = [
                @"
Bite. Melee Weapon Attack: +6 to hit, reach 5ft, one target.
Hit: 1 piercing damage 7 (3d4) poison damage."
                ];
            Abilities = [
                @"                
Flyby. the snake doesn`t provoke opportunity attacks when it
flies out of an enemy`s reach."
            ];
            HasMultiAttack = false;
            HasSaveOnAttack = true;
            Attacks =
            [
                new(ActionList.Bite, DamageTypes.Piercing,RangeTypes.Melee, "1d1", 4, 5, DamageTypes.Poison, "3d4", 8, AttributeName.Constitution)

            ];
        }
    }
}