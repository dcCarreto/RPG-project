using Base;

namespace BestiaryIndex.BestiaryC0
{
    internal class Hawk : Creature
    {

        public Hawk()
        {
            Name = "Hawk";
            Type = CreatureTypes.Beast;
            Size = Sizes.Tiny;
            Alignment = Alignments.Unaligned;
            HitPoints = 1 + Roll(4) - 1;
            AttributeValue = [5, 16, 8, 2, 14, 6];
            ArmorClass = 13;
            Speed = "10ft, fly 60ft";
            Experience = 10;
            ChallengeLevel = "0";
            Skills = "Perception +4";
            Senses = "passive Perception 14";
            Actions = [
                @"
Talons. Melee Weapon Attack: +5 to hit, reach 5 ft., one target.
Hit: 1 slashing damage."
            ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Abilities = [
                @"
Keen Sight. The hawk has advantage on Wisdom (Perception) checks that rely on sight."
             ];
            Attacks = 
            [
                new (ActionList.Talons, DamageTypes.Slashing, RangeTypes.Melee, "1d2")
            ];
        }
    }
}