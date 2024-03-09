using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatures.BestiaryC2
{
    internal class SahuaginPriestess : Creature
    {
        public SahuaginPriestess()
        {
            Name = "Sahuagin Priestess";
            Type = Types.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.LawfulEvil;
            HitPoints = 33 + RollMultiple(6, 8) + 6;
            ArmorClass = 12;
            Speed = "30ft, swim 40ft";
            Attributes = [13, 11, 12, 12, 14, 13];
            ChallengeLevel = "2";
            Experience = 450;
            Skills = "Perception +6, Religion +3";
            Senses = "darkvision 12-ft, passive Perception 16";
            Languages = "Sahuagin";
            Actions = [
                @"
Multiattack. The sahuagin makes two attacks: one with her
bite and one with her claws.",
                @"
Bite. Melee Weapon Attack: +3 to hit, reach 5 ft., one target.
Hit: 3 (ld4 + 1) piercing damage.",
                @"
Claws. Melee Weapon Attack: +3 to hit, reach 5 ft., one target.
Hit: 3 (ld4 + 1) slashing damage."
                ];
            Abilities = [
                @"
Blood Frenzy. The sahuagin has advantage on melee attack
rolls against any creature that doesn't have all its hit points.",
                @"
Limited Amphibiousness. The sahuagin can breathe air and
water, but she needs to be submerged at least once every 4
hours to avoid suffocating.",
                @"
Shark Telepathy. The sahuagin can magically command any
shark within 120 feet of her, using a limited telepathy.",
                @"
Spellcasting. The sahuagin is a 6th-level spellcaster. Her
spellcasting ability is Wisdom (spell save DC 12, +4 to hit with
spell attacks). She has the following cleric spells prepared:
Cantrips (at will): guidance, thaumaturgy
1st level (4 slots): bless, detect magic, guiding bolt
2nd level (3 slots): hold person, spiritual weapon (trident)
3rd level (3 slots): mass healing word, tongues"
                ];
        }
    }
}
