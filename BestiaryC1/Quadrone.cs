namespace Creatures.BestiaryC1
{
    internal class Quadrone : CreatureAttributes
    {

        public Quadrone()
        {
            Name = "Quadrone";
            Type = co;
            Size = l;
            Alignment = ln;
            HitPoints = 22 + RollMultiple(8, 4) + 4;
            ArmorClass = 16;
            Speed = "30ft, fly 30ft";
            Attributes = [12, 14, 12, 10, 10, 11];
            ChallengeLevel = "1";
            Experience = 200;
            Skills = "PErception +2";
            Senses = "truesight 120ft, passive Perception 12";
            Languages = "Modron";
            Actions = [
                @"
Multiattack. The quad rone makes two fist attacks or four
shortbow attacks.",
@"
Fist. Melee Weapon Attack: +3 to hit, reach 5 ft., one target. Hit:
3 (1d4 + 1) bludgeoning damage.",
@"
Shortbow. Ranged Weapon Attack: +4 to hit, range 80(320 ft, one target.
Hit: 5 (1d6 + 2) piercing damage."
                ];
            Abilities = [
                @"
Axiomatic Mind. The quadrone can't be compelled to act in a
manner contrary to its nature or its in s tructions .",
@"
Disintegration. If the quad rone dies, its body di sintegrates
into dust, leaving behind its weapons and anything e lse it
was carrying."
                ];
        }
    }
}
