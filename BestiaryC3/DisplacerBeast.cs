using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.BestiaryC3
{
    internal class DisplacerBeast : Creature
    {
        public DisplacerBeast()
        {
            Name = "Displacer Beast";
            Type = Types.Monstruosity;
            Size = Sizes.Large;
            Alignment = Alignments.LawfulEvil;
            HitPoints = 85 + RollMultiple(10, 10) + 30;
            ArmorClass = 13;
            Speed = "40ft";
            Attributes = [18, 15, 16, 6, 12, 8];
            ChallengeLevel = "3";
            Experience = 700;
            Senses = "darkvision 60ft, passive Perception 11";
            Actions = [
                @"
Multiattack. The displacer beast makes two attacks with its
tentacles.",
                @"
Tentacle. Melee Weapon Attack: +6 to hit, reach 10ft., one
target. Hit: 7 (ld6 + 4) bludgeoning damage plus 3 (1d6)
piercing damage."
                ];
            Abilities = [
                @"
Avoidance. If the displacer beast is subjected to an effect that
allows it to make a saving throw to take only half damage, it
instead takes no damage if it succeeds on the saving throw,
and only half damage if it fails .",
                @"
Displacement. The displacer beast projects a magical illusion
that makes it appear to be standing near its actual location,
causing attack rolls against it to have disadvantage. If it is hit
by an attack, this trait is disrupted until the end of its next
turn. This trait is also disrupted while the displacer beast is
incapacitated or has a speed of O."
                ];
        }
    }
}
