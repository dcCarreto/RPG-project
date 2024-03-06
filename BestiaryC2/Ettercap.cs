namespace Creatures.BestiaryC2
{
    internal class Ettercap : Creature
    {

        public Ettercap()
        {
            Name = "Ettercap";
            Type = mo;
            Size = m;
            Alignment = ne;
            HitPoints = 44 + RollMultiple(8, 8) + 8;
            ArmorClass = 13;
            Speed = "30ft, climb 30ft";
            Attributes = [14, 15, 13, 7, 12, 8];
            ChallengeLevel = "2";
            Experience = 450;
            Skills = "Perception +3, Stealth +4, Survival +3";
            Senses = "darkvision 60ft, passive Perception 13";
            Actions = [
                @"
Multiattack. The ettercap makes two attacks: one with its bite
and one with its claws.",
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft., one creature.
Hit: 6 (ld8 + 2) piercing damage plus 4 (1d8) poison damage.
The target must succeed on a DC 11 Constitution saving throw
or be poisoned for 1 minute. The creature can repeat the saving
throw at the end of each of its turns, ending the effect on itself
on a success.",
                @"
Claws. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 7 (2d4 + 2) slashing damage.",
                @"
Web (Recharge 5-6). Ranged Weapon Attack: +4 to hit, range
30J60 ft. , one Large or smaller creature. Hit: The creature is
restrained by webbing. As an action, the restrained creature
can make a DC 11 Strength check, escaping from the webbing
on a success. The effect ends if the webbing is destroyed. The
webbing has AC 10, 5 hit points, res istance to bludgeoning
damage, and immunity to poison and psychic damage."
                ];
            Abilities = [
                @"
Spider Climb. The ettercap can climb difficult surfaces,
including upside down on ceilings, without needing to make an
ability check.",
                @"
Web Sense. While in contact with a web, the ettercap knows
the exact location of any other creature in contact with
the same web.",
                @"
Web Walker. The ettercap ignores movement restrictions
caused by webbing."
                ];
        }
    }
}
