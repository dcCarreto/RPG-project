using Base;
namespace BestiaryIndex.BestiaryC0
{
    internal class Bat : Creature
    {

        public Bat()
        {
            Name = "Bat";
            Type = Types.Beast;
            Size = Sizes.Tiny;
            Alignment = Alignments.Unaligned;
            HitPoints = 1 + Roll(4) - 1;
            AttributeValue = [2, 15, 8, 2, 12, 4];
            ArmorClass = 12;
            Speed = "5ft, fly 30ft";
            Experience = 10;
            ChallengeLevel = "0";
            Senses = "blindsight 60ft, passive Perception 11";
            Actions = [
                @"
Bite. Melee Weapon Attack: +0 to hit, reach 5ft, one creature.
Hit: 1 piercing damage."
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Abilities = [
                @"
Keen Hearing. The bat has advantage on Wisdom (Perception) checks that rely on hearing.",
                @"
Echolocation. The bat can't use its blind sight while deafened."
            ];
            Attacks = 
            [
                new (AttackList.Bite, DamageTypes.Piercing, RangeTypes.Melee, "1d2" )
            ];

        }
    }
}
