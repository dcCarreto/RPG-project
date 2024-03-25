using Base;

namespace BestiaryIndex.BestiaryC1o8
{
    internal class PoisonousSnake : Creature
    {

        public PoisonousSnake()
        {
            Name = "Poisonous Snake";
            Type = Types.Beast;
            Size = Sizes.Tiny;
            Alignment = Alignments.Unaligned;
            HitPoints = 2 + Roll(4);
            AttributeValue = [2, 16, 11, 1, 10, 3];
            ArmorClass = 13;
            Speed = "30ft, swim 30ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Senses = "blindsight 10ft, passive Perception 10";
            Actions = [
                @"
Bite. Melee Weapon Attack: +5 to hit, reach 5ft, one target.
Hit: 1 piercing damage, and the target must make a DC 10 
Constitution saving throw, taking 5 (2d4) poison damage
on a failed save, or half as much damage on a successful one."
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = true;
            Attacks = [
                new(ActionList.Bite, DamageTypes.Piercing, RangeTypes.Melee, "1d1", 5, 5, DamageTypes.Poison, "2d4", 10, AttributeName.Constitution)
                ];
        }
    }
}