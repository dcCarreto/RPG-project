namespace Base.BestiaryC1o2
{
    internal class Tridrone : Creature
    {

        public Tridrone()
        {
            Name = "Tridrone";
            Type = Types.Construct;
            Size = Sizes.Medium;
            Alignment = Alignments.LawfulNeutral;
            HitPoints = 16 + RollMultiple(8, 3) + 3;
            ArmorClass = 15;
            Speed = "30ft";
            Attributes = [12, 13, 12, 9, 10, 9];
            ChallengeLevel = "1/2";
            Experience = 100;
            Senses = "trusight 120ft, passive Perception 10";
            Languages = "Modron";
            Actions = [
                @"
Multiattack. The tridrone makes three fist attacks or three
javelin attacks.",
                @"
Fist. Melee Weapon Attack: +3 to hit, reach 5 ft., one target. Hit:
3 (1d4 + 1) bludgeoning damage.",
                @"
javelin. Melee or Ranged Weapon Attack: +3 to hit, reach 5 ft. or
range 30/120 ft., one target. Hit: 4 (ld6 + 1) piercing damage."
                ];
            Abilities = [
                @"
Axiomatic Mind. The tridrone can't be compelled to act in a
manner contrary to its nature or its instructions.",
                @"
Disintegration. If the tridrone dies , its body disintegrates
into dust, leaving behind its weapons and anything else it
was carrying."
                ];
        }
    }
}
