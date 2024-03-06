using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatures.BestiaryC3
{
    internal class Ankylosaurus : Creature
    {
        public Ankylosaurus() 
        {
            Name = "Ankylosaurus";
            Type = ba;
            Size = h;
            Alignment = ud;
            HitPoints = 68 + RollMultiple(12, 8) + 16;
            ArmorClass = 15;
            Speed = "30ft";
            Attributes = [19, 11, 15, 2, 12, 5];
            ChallengeLevel = "3";
            Experience = 700;
            Senses = "passive Perception 11";
            Actions = [
                @"
Tail. Melee Weapon Attack: +7 to hit, reach 10 ft., one target .
Hit: 18 (4d6 + 4) bludgeoning damage. If the target is a
creature, it must succeed on a DC 14 Strength saving throw or
be knocked prone."
                ];
        }
    }
}
