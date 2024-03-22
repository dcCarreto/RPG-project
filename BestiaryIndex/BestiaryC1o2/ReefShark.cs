using Base;

namespace BestiaryIndex.BestiaryC1o2
{
    internal class ReefShark : Creature
    {

        public ReefShark()
        {
            Name = "Reef Shark";
            Type = Types.Beast;
            Size = Sizes.Medium;
            Alignment = Alignments.Unaligned;
            HitPoints = 22 + RollMultiple(8, 4) + 4;
            ArmorClass = 12;
            Speed = "0ft, swim 40ft";
            AttributeValue = [14, 13, 13, 1, 10, 4];
            ChallengeLevel = "1/2";
            Experience = 100;
            Skills = "Perception +2";
            Senses = "blindsight 30ft, passive Perception 12";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 6 (1d8 + 2) piercing damage."
                ];
            Abilities = [
                @"
Pack Tactics. The shark has advantage on an attack roll against
a creature if at least one of the shark's allies is within 5 feet of
the creature and the ally isn't incapacitated.",
                @"
Water Breathing. The shark can breathe only underwater."
                ];
        }
    }
}
