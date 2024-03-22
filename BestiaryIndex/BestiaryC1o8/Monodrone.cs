using Base;

namespace BestiaryIndex.BestiaryC1o8
{
    internal class Monodrone : Creature
    {

        public Monodrone()
        {
            Name = "Monodrome";
            Type = Types.Construct;
            Size = Sizes.Medium;
            Alignment = Alignments.LawfulNeutral;
            HitPoints = 5 + Roll(8 + 1);
            AttributeValue = [10, 13, 12, 4, 10, 5];
            ArmorClass = 15;
            Speed = "30ft, fly 30ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Senses = "truesight 120ft, passive Perception";
            Languages = "Modron";
            Actions = [
                @"
Dagger. Melee Weapon Attack: +3 to hit, reach 5ft, one target.
Hit: 3 (1d4 + 1) piercing damage.",
                @"
Javelin. Melee or Ranged Weapon Attack: +3 to hit, reach 5ft
or ranged 30/120ft, one target.
Hit: 4 (1d6 + 1) piercing damage."
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Abilities = [
                @"
Axiomatic Mind. The monodrone can`t be compelled to act in a
manner contrary to its nature or its instructions.",
                @"
Disintegration. If the monodrone dies, its body disintegrates
into dust, leaving behind its weapons and anything else it
was carrying."
            ];
            Attacks =
                [
                new(AttackList.Dagger, DamageTypes.Piercing, RangeTypes.Melee, "1d4 + 1"),
                new(AttackList.Javelin, DamageTypes.Piercing, RangeTypes.Ranged, "1d6 + 1"),
                new(AttackList.Javelin, DamageTypes.Piercing, RangeTypes.Melee, "1d6 + 1")
                ];
        }
    }
}