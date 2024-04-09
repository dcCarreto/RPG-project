using Base;

namespace BestiaryIndex.BestiaryC1o8
{
    internal class Merfolk : Creature
    {

        public Merfolk()
        {
            Name = "Merfolk";
            Type = CreatureTypes.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.Neutral;
            HitPoints = 11 + RollMultiple(8, 2) + 2;
            AttributeValue = [10, 13, 12, 11, 11, 12];
            ArmorClass = 11;
            Speed = "10ft, swim 40ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Skills = "Perception +2";
            Senses = "passive Perception 12";
            Languages = "Aquan, Common";
            Actions = [
                @"
Spear. Melee or Ranged Attack: +2 to hit, reach 5ft or ranged 20/60ft. one target.
Hit:3 (1d6) piercing damage, or 4 (1d8) piercing damage if used with two hands to
make a melee attack."
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = true;
            Abilities = [
                @"
Amphibious. The merfolk can breath air and water."
            ];
            Attacks =
            [
                new(ActionList.Spear, DamageTypes.Piercing,RangeTypes.Melee, "1d6"),
                new(ActionList.Spear, DamageTypes.Piercing,RangeTypes.Melee, "1d8"),
                new(ActionList.Spear, DamageTypes.Piercing,RangeTypes.Ranged, "1d4")

            ];
        }
    }
}