namespace Creatures.BestiaryC1
{
    internal class GiantOctopus : CreatureAttributes
    {

        public GiantOctopus()
        {
            Name = "Giant Octopus";
            Type = ba;
            Size = l;
            Alignment = ud;
            HitPoints = 52 + RollMultiple(10, 8) + 8;
            ArmorClass = 11;
            Speed = "10ft, swim 60ft";
            Attributes = [17, 13, 13, 4, 10, 4];
            ChallengeLevel = "1";
            Experience = 200;
            Skills = "Perception +4, Stealth +5";
            Senses = "darkvision 60ft, passive Perception 14";
            Actions = [
                @"
Tentacles. Melee Weapon Attack: +5 to hit, reach 15 ft., one
target. Hit: 10 (2d6 + 3) bludgeoning damage. If the target is a
creature, _it is grappled (escape DC 16). Until this grapple ends,
the target is restrained, and the octopus can't use its tentacles
on another target.",
                @"
Ink Cloud (Recharges after a Short or Long Rest). A 20-footradius
cloud of ink extends all around the
octopus if it is underwater. The area is
heavily obscured for 1 minute, although a
significant current can disperse the ink.
After releasing the ink, the octopus can
use the Dash action as a bonus action."
                ];
            Abilities = [
                @"
Hold Breath. While out of water, the octopus can hold its
breath for 1 hour.",
                @"
Underwater Camouflage. The octopus has advantage on
Dexterity (Stealth) checks made while underwater.",
                @"
Water Breathing. The octopus can breathe only underwater."
                ];
        }
    }
}
