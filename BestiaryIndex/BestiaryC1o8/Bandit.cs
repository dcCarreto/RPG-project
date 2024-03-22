using Base;
namespace BestiaryIndex.BestiaryC1o8
{
    internal class Bandit : Creature
    {

        public Bandit()
        {
            Name = "Bandit";
            Type = Types.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.AnyNonGoodAlignment;
            HitPoints = 11 + RollMultiple(8, 2) + 2;
            AttributeValue = [11, 12, 12, 10, 10, 10];
            ArmorClass = 12;
            Speed = "30ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Senses = "passive Perception 10";
            Languages = "any one language (usually common)";
            Actions = [
                @"
Scimitar. Melee Weapon Attack: +3 to hit, reach 5ft, one target.
Hit: 4 (1d6 +1) slashing damage.",
                @"
Light Crossbow. Ranged Weapon Attack: +3 to hit, range 80/320ft,
one Target. Hit: 5 (1d8 + 1) piercing damage."
            ];

            hasMultiAttack = false;
            hasSaveOnAttack = false;
            Attacks =
            [
                new (AttackList.Scimitar, DamageTypes.Slashing, RangeTypes.Melee, "1d6 + 1" ),
                new (AttackList.LightCrossbow, DamageTypes.Piercing, RangeTypes.Ranged, "1d8 + 1")
            ];
        }
    }
}