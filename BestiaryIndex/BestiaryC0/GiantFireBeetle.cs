using Base;

namespace BestiaryIndex.BestiaryC0
{
    internal class GiantFireBeetle : Creature
    {

        public GiantFireBeetle()
        {
            Name = "Giant Fire Beetle";
            Type = Types.Beast;
            Size = Sizes.Small;
            Alignment = Alignments.Unaligned;
            HitPoints = 4 + Roll(6) + 1;
            AttributeValue = [8, 10, 12, 1, 7, 3];
            ArmorClass = 13;
            Speed = "30ft";
            Experience = 10;
            ChallengeLevel = "0";
            Senses = "blindsight 30ft, passive Perception 8";
            Actions = [
                @"
Bite. Melee Weapon Attack:+ 1 to hit, re ach 5 ft., one target.
Hit: 2 (1d6 - 1), slashing damage."
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Abilities = [
                @"
Illumination. The beetle sheds bright light in a 10-foot radius
and dim light for an additional 10 feet."
            ];
            Attacks =
            [
                new (AttackList.Bite, DamageTypes.Slashing, RangeTypes.Melee, "1d6 - 1")
            ];
        }
    }
}