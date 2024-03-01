namespace Creatures.BestiaryC2
{
    internal class Pentadrone : Creatures
    {

        public Pentadrone()
        {
            Name = "Pentadrone";
            Type = co;
            Size = l;
            Alignment = ln;
            HitPoints = 32 + RollMultiple(10, 5) + 5;
            ArmorClass = 16;
            Speed = "40ft";
            Attributes = [15, 14, 12, 10, 10, 13];
            ChallengeLevel = "2";
            Experience = 450;
            Skills = "Perception +4";
            Senses = "truesight 120ft, passive Perception 14";
            Languages = "Modron";
            Actions = [
                @"
Multiattack. The pe ntadrone makes five arm attacks.",
                @"
Arm. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 5 (ld6 + 2) bludgeoning damage.",
                @"
Paralysis Gas (Recharge 5-6). The pent adrone ex hales a 30·
foot cone of gas. Each creature in that area must succeed on a
DC ll Constitution saving throw or be paralyzed for 1 minute.
A creature can repeat the saving throw at the end of each of its
turns, ending the effect on itself on a success."
                ];
            Abilities = [
                @"
Axiomatic Mind. The pentadrone can't be compelled to act in a
manner contrary to its nature or its instructions.",
                @"
Disintegration. lfthe pentadrone dies, its body disintegrates
into dust, leaving behind its weapons and anything e lse it
was carrying."
                ];
        }
    }
}
