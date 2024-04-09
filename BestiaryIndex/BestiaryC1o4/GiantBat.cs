using Base;

namespace BestiaryIndex.BestiaryC1o4
{
    internal class GiantBat : Creature
    {

        public GiantBat()
        {
            Name = "Giant Bat";
            Type = CreatureTypes.Beast;
            Size = Sizes.Large;
            Alignment = Alignments.Unaligned;
            HitPoints = 22 + RollMultiple(10, 4);
            ArmorClass = 13;
            Speed = "10ft, fly 60ft";
            AttributeValue = [15, 16, 11, 2, 12, 6];
            ChallengeLevel = "1/4";
            Experience = 50;
            Senses = "blindsight 60ft, passive Perception 11";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft, one creature.
Hit: 5 (1d6 + 2) piercing damage."
                ];
            Abilities = [
                @"
Echolocation. The bat can't use its blindsight while deafened.",
                @"
Keen Hearing. The bat has advantage on Wisdom (Perception) checks
that on hearing."
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Attacks =
                [
                new(ActionList.Bite, DamageTypes.Piercing, RangeTypes.Melee, "1d6 + 2")
                ];

        }
    }
}
