namespace Base.BestiaryC1o4
{
    internal class DuoDrone : Creature
    {

        public DuoDrone()
        {
            Name = "Duo Drone";
            Type = Types.Construct;
            Size = Sizes.Medium;
            Alignment = Alignments.LawfulNeutral;
            HitPoints = 11 + RollMultiple(8, 2) + 2;
            ArmorClass = 15;
            Speed = "30ft";
            Attributes = [11, 13, 12, 6, 10, 7];
            ChallengeLevel = "1/4";
            Experience = 50;
            Senses = "truesight 120ft, passice Perception 10";
            Languages = "Modron";
            Actions = [
                @"
Multiattack. The duodrone makes two fist attacks or two
javelin attacks.",
                @"
Fist. Melee Weapon Attack: +2 to hit, reach 5 ft, one target.
Hit: 2 (1d4) bludgeoning damage.",
                @"
Javelin. Melee or Ranged Weapon Attack: +3 to hit, reach 5 ft
or range 30/120 ft, one target.
Hit: 4 (1d6 + 1) piercing damage."
                ];
            Abilities = [
                @"
Axiomatic Mind. The duodrone can't be compelled to act in a
manner contrary to its nature or its instructions.",
                @"
Disintegration. If the duodrone dies, its body disintegrates
into dust, leaving behind its weapons and anything else it
was carrying."
                ];
        }
    }
}
