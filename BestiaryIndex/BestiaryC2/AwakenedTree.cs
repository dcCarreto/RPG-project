using Base;

namespace BestiaryIndex.BestiaryC2
{
    internal class AwakenedTree : Creature
    {
        public AwakenedTree()
        {
            Name = "Awakened Tree";
            Type = CreatureTypes.Plant;
            Size = Sizes.Huge;
            Alignment = Alignments.Unaligned;
            HitPoints = 59 + RollMultiple(12, 7) + 14;
            ArmorClass = 13;
            Speed = "20ft";
            AttributeValue = [19, 6, 15, 10, 10, 7];
            ChallengeLevel = "2";
            Experience = 450;
            DamageVulnerabilities = "fire";
            DamageResistances = "bludgeoning, piercing";
            Senses = "passive Perception 10";
            Languages = "one language known by its creator";
            Actions = [
                @"
Slam. Melee Weapon Attack: +6 to hit, reach 10ft., one target.
Hit: 14 (3d6 + 4) bludgeoning damage."
                ];
            Abilities = [
                @"
False Appearance. While the tree remains motionless, it is
indistinguishable from a normal tree."
                ];
        }
    }
}
