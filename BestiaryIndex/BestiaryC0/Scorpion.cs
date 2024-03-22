using Base;
namespace BestiaryIndex.BestiaryC0
{
    internal class Scorpion : Creature
    {

        public Scorpion()
        {
            Name = "Scorpion";
            Type = Types.Beast;
            Size = Sizes.Tiny;
            Alignment = Alignments.Unaligned;
            HitPoints = 1 + Roll(4) - 1;
            AttributeValue = [2, 11, 8, 1, 8, 2];
            ArmorClass = 11;
            Speed = "10ft";
            Experience = 10;
            ChallengeLevel = "0";
            Senses = "blindsight 10ft, passive Perception 9";
            Actions = [
                @"
Sting. Melee Weapon Attack: +2 to hit, reach 5 ft. , one creature.
Hit: 1 piercing damage, and the target must make a DC 9 Constitution
saving throw, taking 4 (1d8) poison damage on a failed save, or half
as much damage on a successful one."
            ];
            HasMultiAttack = false;
            HasSaveOnAttack = true;
            Attacks = 
            [
                new ( AttackList.Sting, DamageTypes.Piercing, RangeTypes.Melee, "1d1", 1, 5, DamageTypes.Poison, "1d4", 9, AttributeName.Constitution)
            ];
        }
    }
}