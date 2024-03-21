using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.BestiaryC3
{
    internal class Basilisk : Creature
    {
        public Basilisk() 
        {
            Name = "Basilisk";
            Type = Types.Monstruosity;
            Size = Sizes.Medium;
            Alignment = Alignments.Unaligned;
            HitPoints = 52 + RollMultiple(8, 8) + 16;
            ArmorClass = 15;
            Speed = "20ft";
            Attributes = [16, 8, 15, 2, 8, 7];
            ChallengeLevel = "3";
            Experience = 700;
            Senses = "darkvision 60ft, passive Perception 9";
            Actions = [
                @"
Bite. Melee Weapon Attack: +5 to hit, reach 5 ft., one target.
Hit: 10 (2d6 + 3) piercing damage plus 7 (2d6) poison damage."
                ];
            Abilities = [
                @"
Petrifying Gaze. If a creature starts its turn within 30 feet of the
basilisk and the two of them can see each other, the basilisk
can force the creature to make a DC 12 Constitution saving
throw if the basilisk isn't incapacitated. On a failed save, the
creature magically begins to turn to stone and is restrained. It
must repeat the saving throw at the end of its next turn. On a
success, the effect ends. On a failure , the creature is petrified
until freed by the greater restoration spell or other magic.
A creature that isn't surprised can avert its eyes to avoid the
saving throw at the start of its turn. If it does so, it can't see
the basilisk until the start of its next turn, when it can avert its
eyes again. If it looks at the basilisk in the meantime, it must
immediately make the save.
If the basilisk sees its reflection within 30 feet of it in bright
light, it mistakes itself for a rival and targets itself with its gaze."
                ];
        }
    }
}
