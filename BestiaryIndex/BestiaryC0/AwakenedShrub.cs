using Base; 

namespace BestiaryIndex.BestiaryC0
{
    internal class AwakenedShrub : Creature
    {

        public AwakenedShrub()
        {
            Name = "Awakened Shrub";
            Type = Types.Plant;
            Size = Sizes.Small;
            Alignment = Alignments.Unaligned;
            HitPoints = 10 + RollMultiple(6, 3);
            AttributeValue = [3, 8, 11, 10, 10, 6];
            ArmorClass = 9;
            Speed = "20ft";
            Experience = 10;
            ChallengeLevel = "0";
            DamageVulnerabilities = "fire";
            DamageResistances = "piercing";
            Senses = "passive Perception 10";
            Languages = "one language known by its creator";
            Actions = [
                @"
Rake. Melee Weapon Attack: +1 to hit, reach 5 ft, one target.
Hit: 1 (1d4 - 1), slashing damage."
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Abilities = [
                @"
False Appearance. While the shrub remains motionless, it is indistinguishable from a normal shrub."
                ];
            Attacks =
            [
                new (ActionList.Rake, DamageTypes.Slashing, RangeTypes.Melee, "1d4")
            ];
        }
    }
}
