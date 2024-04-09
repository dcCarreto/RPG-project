using Base;

namespace BestiaryIndex.BestiaryC1o2
{
    internal class Satyr : Creature
    {

        public Satyr()
        {
            Name = "Satyr";
            Type = CreatureTypes.Fey;
            Size = Sizes.Medium;
            Alignment = Alignments.ChaoticNeutral;
            HitPoints = 31 + RollMultiple(8, 7);
            ArmorClass = 14;
            Speed = "40ft";
            AttributeValue = [12, 16, 11, 12, 19, 14];
            ChallengeLevel = "1/2";
            Experience = 100;
            Skills = "Perceptionm +2, Performance +6, Stealth +5";
            Senses = "passive Perception 12";
            Languages = "Common, Elvish, Sylvian";
            Actions = [
                @"
Ram. Melee Weapon Attack: +3 to hit, reach 5 ft., one target.
Hit: 6 (2d4 + 1) bludgeoning damage.",
@"
Shortsword. Melee Weapon Attack: +5 to hit, reach 5 ft., one
target. Hit: 6 (1 6 + 3) piercing damage.",
@"
Shortbow. Ranged Weapon Attack: +5 to hit, ra nge 80/320 ft.,
one target. Hit: 6 (ld6 + 3) piercing damage."
                ];
            Abilities = [
                @"
Magic Resistance. The satyr has adva ntage on savin g throws
against spells and other magical effects."
                ];
        }
    }
}
