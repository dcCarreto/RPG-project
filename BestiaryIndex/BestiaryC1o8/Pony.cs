using Base;

namespace BestiaryIndex.BestiaryC1o8
{
    internal class Pony : Creature
    {

        public Pony()
        {
            Name = "Pony";
            Type = Types.Beast;
            Size = Sizes.Medium;
            Alignment = Alignments.Unaligned;
            HitPoints = 11 + RollMultiple(8, 2) + 2;
            AttributeValue = [15, 10, 13, 2, 11, 7];
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
            hasMultiAttack = false;
            hasSaveOnAttack = false;
            Attacks = [
                new(AttackList.Hooves, DamageTypes.Bludgeoning, RangeTypes.Melee, "2d4 + 2")
                ];
        }
    }
}