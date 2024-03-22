using Base;
namespace BestiaryIndex.BestiaryC0
{
    internal class Cat : Creature
    {

        public Cat()
        {
            Name = "Cat";
            Type = Types.Beast;
            Size = Sizes.Tiny;
            Alignment = Alignments.Unaligned;
            HitPoints = 2 + Roll(4);
            AttributeValue = [3, 15, 10, 3, 12, 7];
            ArmorClass = 12;
            Speed = "40ft, climb 30ft";
            Experience = 10;
            ChallengeLevel = "0";
            Skills = "Perception +3, Stealth +4";
            Senses = "passive Perception 13";
            Actions = [
                @"
Claws. Melee Weapon Attack: +0 to hit, reach 5 ft, one target.
Hit: 1 slashing damage."
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Abilities = [
                @"
Keen Smell. The cat has advantage on Wisdom (Perception) checks that rely on smell."
                ];
            Attacks = 
            [
                new (AttackList.Bite, DamageTypes.Piercing, RangeTypes.Melee, "1d2" )
            ];

        }
    }
}
