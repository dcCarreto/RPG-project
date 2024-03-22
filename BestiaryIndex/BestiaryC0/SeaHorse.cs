using Base;
namespace BestiaryIndex.BestiaryC0
{
    internal class SeaHorse : Creature
    {

        public SeaHorse()
        {
            Name = "Sea Horse";
            Type = Types.Beast;
            Size = Sizes.Tiny;
            Alignment = Alignments.Unaligned;
            HitPoints = 1 + Roll(4) - 1;
            AttributeValue = [1, 12, 8, 1, 10, 2];
            ArmorClass = 11;
            Speed = "0ft, swim 20ft";
            Experience = 0;
            ChallengeLevel = "0";
            Senses = "passive Perception 10";
            Abilities = [
                @"
Water Breathing. The sea horse can breathe only underwater."
            ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Attacks = 
            [
                new ( AttackList.Ram, DamageTypes.Bludgeoning, RangeTypes.Melee, "1d1")
            ];
        }
    }
}