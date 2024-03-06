namespace Creatures.BestiaryC1o2
{
    internal class Cockatrice : Creature
    {

        public Cockatrice()
        {
            Name = "Cockatrice";
            Type = mo;
            Size = s;
            Alignment = ud;
            HitPoints = 27 + RollMultiple(6, 6) + 6;
            ArmorClass = 11;
            Speed = "20ft, fly 40ft";
            Attributes = [6, 12, 12, 2, 13, 5];
            ChallengeLevel = "1/2";
            Experience = 100;
            Senses = "darkvision 60ft, passive Perception 11";
            Actions = [
                @"
Bite. Melee Weapon Attack: +3 to hit, reach 5 ft, one creature.
Hit: 3 (1d4 + 1) piercing damage, and the target must succeed
on a DC 11 Constitution saving throw against being magically
petrified. On a failed save, the creature begins to turn to stone
and is restrained. It must repeat the saving throw at the end of
its next turn. On a success, the effect ends. On a failure, the
creature is petrified for 24 hours."
                ];
        }
    }
}
