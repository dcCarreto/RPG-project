using Base;

namespace BestiaryIndex.BestiaryC1o8
{
    internal class GiantWeasel : Creature
    {

        public GiantWeasel()
        {
            Name = "Giant Weasel";
            Type = CreatureTypes.Beast;
            Size = Sizes.Medium;
            Alignment = Alignments.Unaligned;
            HitPoints = 9 + RollMultiple(8, 2);
            AttributeValue = [11, 16, 10, 4, 12, 5];
            ArmorClass = 13;
            Speed = "40ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Skills = "Perception +3, Stealth +5";
            Senses = "darkvision 60ft, passive Perception 13";
            Actions = [
                @"
Bite. Melee Weapon Attack: +5 to hit, reach 5ft, one target.
Hit: 5 (1d4 +3) piercing damage."
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Abilities = [
                @"                
Keen Hearing and Smell. The weasel had advantage on Wisdom
(Perception) checks that rely on hearing and smell."

            ];
            Attacks =
            [
                new(ActionList.Bite, DamageTypes.Piercing,RangeTypes.Melee, "1d4 + 3")

            ];
        }
    }
}