namespace Creatures.BestiaryC2
{
    internal class Allosaurus : CreatureAttributes
    {

        public Allosaurus()
        {
            Name = "Allosaurus";
            Type = ba;
            Size = l;
            Alignment = ud;
            HitPoints = 51 + RollMultiple(10, 6) + 18;
            ArmorClass = 13;
            Speed = "60ft";
            Attributes = [19, 13, 17, 2, 12, 5];
            ChallengeLevel = "2";
            Experience = 450;
            Skills = "Perception +5";
            Senses = "passive Perception 15";
            Actions = [
                @"
Bite. Melee Weapon Attack: +6 to hit, reach 5 ft., one target.
Hit: 15 (2d10 + 4) piercing damage.",
                @"
Claw. Melee Weapon Attack: +6 to hit, reach 5 ft., one target.
Hit: 8 (ld8 + 4) slashing damage."
                ];
            Abilities = [
                @"
Pounce. If the a llosaurus moves at least 30 feet straight toward
a creature and then hits it with a claw attack on the same turn,
that target must succeed on a DC 13 Strength saving throw
or be knocked prone. If the target is prone, the allosaurus can
make one bite attack against it as a bonus action."
                ];
        }
    }
}
