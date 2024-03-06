namespace Creatures.BestiaryC0
{
    internal class Quipper : Creature
    {

        public Quipper()
        {
            Name = "Quipper";
            Type = ba;
            Size = t;
            Alignment = ud;
            HitPoints = 1 + Roll(4) - 1;
            Attributes = [2, 16, 9, 1, 7, 2];
            ArmorClass = 13;
            Speed = "0ft, swim 40ft";
            Experience = 10;
            ChallengeLevel = "0";
            Senses = "darkvision 60ft, passive Perception 8";
            Actions = [
                @"
Bite. Melee Weapon Attack: +5 to hit, reach 5 ft. , one target. Hit: 1 piercing damage."
            ];
            Abilities = [
                @"
Blood Frenzy. The quipper has advantage on melee attack rolls against any creature that doesn't have all its hit points.",
                @"
Water Breathing. The quipper can breathe only underwater."
            ];
        }
    }
}