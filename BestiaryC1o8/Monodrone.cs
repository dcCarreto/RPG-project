namespace Creatures.BestiaryC1o8
{
    internal class Monodrone : Creatures
    {

        public Monodrone()
        {
            Name = "Monodrome";
            Type = co;
            Size = m;
            Alignment = ln;
            HitPoints = 5 + Roll(8 + 1);
            Attributes = [10, 13, 12, 4, 10, 5];
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
            Abilities = [
                @"
Axiomatic Mind. The monodrone can`t be compelled to act in a
manner contrary to its nature or its instructions.",
                @"
Disintegration. If the monodrone dies, its body disintegrates
into dust, leaving behind its weapons and anything else it
was carrying."
            ];
        }
    }
}