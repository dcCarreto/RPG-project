using Base;

namespace BestiaryIndex.BestiaryC1o4
{
    internal class Aarakocra : Creature
    {

        public Aarakocra()
        {
            Name = "Aarakocra";
            Type = Types.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.NeutralGood;
            HitPoints = 13 + RollMultiple(8, 3);
            AttributeValue = [10, 14, 10, 11, 12, 11];
            ArmorClass = 12;
            Speed = "20ft, fly 50ft";
            Experience = 50;
            ChallengeLevel = "1/4";
            Skills = "Perception +5";
            Senses = "passive Perception 15";
            Languages = "Auran";
            Actions = [
                @"
Dive Attack. If the aarakocra is flying and dives at least 30ft
straight toward a target and then hits it with a melee weapon
attack, the attack deals an extra 3 (1d6) damage to the target
",
                @"
Javelin. Melee or Ranged Weapon Attack: +4 to hit, reach 5ft, or
ranged 30/120ft, one target.
Hit: 5 (1d6 +2) piercing damage.",
                @"
Talon. Melee Weapon Attack: +4 to hit, reach 5ft, one target.
Hit: 4 (1d4 + 2) slashing damage."
            ];

            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Attacks = [
                new(ActionList.Dive, DamageTypes.Slashing, RangeTypes.Melee, "1d6"),
                new(ActionList.Javelin, DamageTypes.Piercing, RangeTypes.Melee, "1d6 + 2"),
                new(ActionList.Javelin, DamageTypes.Piercing, RangeTypes.Ranged, "1d6 + 2"),
                new(ActionList.Talons, DamageTypes.Slashing, RangeTypes.Melee, "1d4 + 2")
                ];
        }
    }
}
