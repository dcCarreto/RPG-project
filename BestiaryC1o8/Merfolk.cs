namespace Creatures.BestiaryC1o8
{
    internal class Merfolk : Creature
    {

        public Merfolk()
        {
            Name = "Merfolk";
            Type = Types.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.Neutral;
            HitPoints = 11 + RollMultiple(8, 2) + 2;
            Attributes = [10, 13, 12, 11, 11, 12];
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
            Abilities = [
                @"
Amphibious. The merfolk can breath air and water."
            ];
        }
    }
}