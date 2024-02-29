using Creatures.Main;

namespace Creatures.BestiaryC1o2
{
    internal class Svirfneblin : Creatures
    {
        readonly Dices dice = new();
        public Svirfneblin()
        {
            Name = "Deep Gnome (Svirfneblin)";
            Type = hu;
            Size = s;
            Alignment = ng;
            HitPoints = 16 + dice.RollMultiple(6, 3) + 6;
            ArmorClass = 15;
            Speed = "20ft";
            Attributes = [15, 14, 14, 12, 10, 9];
            ChallengeLevel = "1/2";
            Experience = 100;
            Skills = "Investigation +3, Perception +2, Stealth +4";
            Senses = "darkvision 120ft, passive Perception 12";
            Languages = "Gnomish, Terran, Undercommon";
            Actions = [
                @"
War Pick. Melee Weapon Attack: +4 to hit, reach 5 ft, one target.
Hit: 6 (1d8 + 2) piercing damage.",
                @"
Poisoned Dart. Ranged Weapon Attack: +4 to hit, range 30/120
ft, one creature. Hit: 4 (1d4 + 2) pi ercing damage, and the
target must succeed on a DC 12 Constitution saving th row or
be poisoned for 1 minute. The target can repeat the saving
throw at the end of each of its turns, ending the effect on itself
on a success."
                ];
            Abilities = [
                @"
Stone Camouflage. The gnome has advantage on Dexterity
(Stealth) checks made to hide in rocky terrain.",
                @"
Gnome Cunning. The gnome has advantage on Intelligence,
Wisdom, and Charisma saving throws again st magic.",
                @"
Innate Spellcasting. The gnome's inn ate spellcasting ability is
Intelligence (spell save DC 11). It can innately cast the following
spells, requiring no material components:
At will: nondetection (self only)
1/day each: blindness/deafness, blur, disguise self"
                ];
        }
    }
}
