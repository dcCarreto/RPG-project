using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.BestiaryC3
{
    internal class GithyankiWarrior : Creature
    {
        public GithyankiWarrior()
        {
            Name = "Githyanki Warrior";
            Type = Types.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.LawfulEvil;
            HitPoints = 49 + RollMultiple(8, 9) + 9;
            ArmorClass = 17;
            Speed = "30ft";
            Attributes = [15, 14, 12, 13, 13, 10];
            ChallengeLevel = "3";
            Experience = 700;
            SavingThrows = "Constitution +3, Intelligence +3, Wisdom +3";
            Senses = "passive Perception 11";
            Languages = "Gith";
            Actions = [
                @"
Multiattack. The githyanki makes two greatsword attacks .",
                @"
Greatsword. Melee Weapon Attack: +4 to hit, reach 5 ft .,
one target. Hit: 9 (2d6 + 2) slashing damage plus 7 (2d6)
psychic damage."
                ];
            Abilities = [
                @"
Innate Spel/casting (Psionics). The githyanki's innate
spellcasting ability is Intelligence. It can innately cast the
following spells, requiring no components:
At will: mage hand (the hand is invisible)
3jday each: jump, misty step, nondetection (self only)"
                ];
        }
    }
}
