namespace Creatures.BestiaryC2
{
    internal class HunterShark : Creature
    {
        public HunterShark()
        {
            Name = "Hunter Shark";
            Type = Types.Beast;
            Size = Sizes.Large;
            Alignment = Alignments.Unaligned;
            HitPoints = 45 + RollMultiple(10, 6) + 12;
            ArmorClass = 12;
            Speed = "0ft, swim 40ft";
            Attributes = [18, 13, 15, 1, 10, 4];
            ChallengeLevel = "2";
            Experience = 450;
            Skills = "Perception +2";
            Senses = "blindsight 30ft, passive Perception 12";
            Actions = [
                @"
Bite. Melee Weapon Attack: +6 to hit, reach 5 ft., one target.
Hit: 13 (2d8 + 4) piercing damage."
                ];
            Abilities = [
                @"
Blood Frenzy. The shark has advantage on melee attack rolls
against any creature that doesn't have all its hit points.",
                @"
Water Breathing. The shark can breathe only underwater."
                ];
        }
    }
}
