using Creatures.Main;

namespace Creatures.BestiaryC1
{
    internal class Lion : Creatures
    {
        readonly Dices dice = new();
        public Lion()
        {
            Name = "Lion";
            Type = ba;
            Size = l;
            Alignment = ud;
            HitPoints = 26 + dice.RollMultiple(10, 4) + 4;
            ArmorClass = 12;
            Speed = "50ft";
            Attributes = [17, 15, 13, 3, 12, 8];
            ChallengeLevel = "1";
            Experience = 200;
            Skills = "Perception +3, Stealth +6";
            Senses = "passive Perception 13";
            Actions = [
                @"
Bite. Melee Weapon Attack: +5 to hit, reach 5 ft., one target.
Hit: 7 (1d8 + 3) piercing damage.",
                @"
Claw. Melee Weapon Attack: +5 to hit, reach 5 ft., one target.,
Hit: 6 (1d6 + 3) slashing damage."
                ];
            Abilities = [
                @"
Keen Smell. The lion has advantage on Wisdom (Perception)
checks that rely on smell.",
                @"
Pack Tactics. The lion has advantage on an attack roll against a
creature if at least one of the lion's allies is within 5 feet of the
creature and the ally isn 't incapacitated .",
                @"
Pounce. If the lion moves at least 20 feet straight toward a
creature and then hits it with a claw attack on the same turn,
that target must succeed on a DC 13 Strength saving throw or
be knocked prone. If the target is prone, the lion can make one
bite attack against it as a bonus action.",
                @"
Running Leap. With a 10-foot running start, the lion can long
jump up to 25 feet."
                ];
        }
    }
}
