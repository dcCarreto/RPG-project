using Base;

namespace BestiaryIndex.BestiaryC1o8
{
    internal class Guard : Creature
    {

        public Guard()
        {
            Name = "Guard";
            Type = Types.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.AnyAlignment;
            HitPoints = 11 + RollMultiple(8, 2) + 2;
            AttributeValue = [13, 12, 12, 10, 11, 10];
            ArmorClass = 16;
            Speed = "30ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Skills = "Perception +2";
            Senses = "passive Perception 12";
            Languages = "any one language (usually Common)";
            Actions = [
                @"
Spear. Melee or Ranged Weapon Attack: +3 to hit,
reach 5ft, or ranged 20/60ft, one target.
Hit: 4 (1d6 +1) piercing damage."
                ];
            hasMultiAttack = false;
            hasSaveOnAttack = false;
            Attacks =
            [
                new(AttackList.Spear, DamageTypes.Piercing,RangeTypes.Melee, "1d6 + 1"),
                new(AttackList.Spear, DamageTypes.Piercing,RangeTypes.Ranged, "1d6 + 1")
            ];
        }
    }
}