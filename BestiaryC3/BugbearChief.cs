using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.BestiaryC3
{
    internal class BugbearChief : Creature
    {
        public BugbearChief()
        {
            Name = "Bugbear Chief";
            Type = Types.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.ChaoticEvil;
            HitPoints = 65 + RollMultiple(8, 10) + 20;
            ArmorClass = 17;
            Speed = "30ft";
            Attributes = [17, 14, 14, 11, 12, 11];
            ChallengeLevel = "3";
            Experience = 700;
            Skills = "Intimidation +2, Stealth +6, Survival +3";
            Senses = "darkvision 60ft, passive Perception 10";
            Languages = "Common, Goblin";
            Actions = [
                @"
Multiattack. The bugbear makes two melee attacks.",
                @"
Morningstar. Melee Weapon Attack: +5 to hit , reach 5 ft., one
target. Hit: 12 (2d8 + 3) piercing damage.",
                @"
javelin. Melee or Ranged Weapon Attack: +5 to hit, reach 5 ft. or
range 30/120 ft ., one target. Hit: 10 (2d6 + 3) piercing damage
in melee or 6 (1d6 + 3) piercing damage at range."
                ];
            Abilities = [
                @"
Brute. A melee weapon deals one extra die of its damage when the
bugbear hits with it (included in the attack).",
@"
Heart ofHruggek. The bugbear has advantage on saving
th rows against being charmed, frightened , para lyzed,
poisoned, stunned, or put to sleep.",
@"
Surprise Attack. If the bugbear surprises a creature and hits it
with an attack during the first round of combat, the target takes
an extra 7 (2d6) damage from the attack."
                ];
        }
    }
}
