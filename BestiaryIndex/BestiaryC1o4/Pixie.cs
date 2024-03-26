using Base;

namespace BestiaryIndex.BestiaryC1o4
{
    internal class Pixie : Creature
    {

        public Pixie()
        {
            Name = "Pixie";
            Type = Types.Fey;
            Size = Sizes.Tiny;
            Alignment = Alignments.NeutralGood;
            HitPoints = 1 + Roll(4) - 1;
            ArmorClass = 15;
            Speed = "10ft, fly 30ft";
            AttributeValue = [2, 20, 8, 10, 14, 15];
            ChallengeLevel = "1/4";
            Experience = 50;
            Skills = "Perception +4, Stealth +7";
            Senses = "passive Perception 14";
            Languages = "Sylvan";
            Actions = [
                @"
Superior Invisibility. The pixie magically turns invisible until
its concentration ends (as if concentrating on a spell). Any
equipment the pixie wears or carries is invisible with it."
                ];
            Abilities = [
                @"
Magic Resistance. The pixie has advantage on saving throws
against spells and other magical effects.",
                @"
Innate Spellcasting. The pixie's innate spellcasting ability is
Charisma (spell save DC 12). It can innately cast the following
spells, requiring only its pixie dust as a component:

At will: druidcraft
1/day each: confusion, dancing lights, detect evil and good,
detect thoughts, dispel magic, entangle, fly, phantasmal force,
polymorph, sleep"
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            
        }
    }
}
