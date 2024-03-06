namespace Creatures.BestiaryC0
{
    internal class Raven : Creature
    {

        public Raven()
        {
            Name = "Raven";
            Type = ba;
            Size = t;
            Alignment = ud;
            HitPoints = 1 + Roll(4) - 1;
            Attributes = [2, 14, 8, 2, 12, 6];
            ArmorClass = 12;
            Speed = "10ft, fly 50ft";
            Experience = 10;
            ChallengeLevel = "0";
            Skills = "Perception +3";
            Senses = "passive Perception 13";
            Actions = [
                @"
Beak. Melee Weapon Attack: +4 to hit, reach 5 ft, one target. Hit: 1 piercing damage."
            ];
            Abilities = [
                @"
Mimicry. The raven can mimic simple sounds it has heard, such as a pe rson whispering,
a baby crying, or an animal chittering. A creature that hears the sounds can tell they
are imitations with a success ful DC 10 Wisdom (In sight) check."
            ];
        }
    }
}