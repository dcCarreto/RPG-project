using Base;
namespace BestiaryIndex.BestiaryC0
{
    internal class Lizard : Creature
    {

        public Lizard()
        {
            Name = "Lizard";
            Type = Types.Beast;
            Size = Sizes.Tiny;
            Alignment = Alignments.Unaligned;
            HitPoints = 2 + Roll(4);
            AttributeValue = [2, 11, 10, 1, 8, 3];
            ArmorClass = 10;
            Speed = "20ft, climb 20ft";
            Experience = 10;
            ChallengeLevel = "0";
            Senses = "darkvision 30ft, passive Perception 9";
            Actions = [
                @"
Bite. Melee Weapon Attack: +0 to hit, reach 5 ft, one target. Hit: 1 piercing damage."
            ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Attacks = 
            [
                new (ActionList.Bite, DamageTypes.Piercing, RangeTypes.Melee, "1d2")
            ];
        }
    }
}