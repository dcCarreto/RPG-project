namespace Creatures.BestiaryC0
{
    internal class Vulture : Creatures
    {
        readonly Dices dice = new();
        public Vulture()
        {
            Name = "Vulture";
            Type = ba;
            Size = m;
            Alignment = ud;
            HitPoints = 5 + dice.Roll(dice.d8 +1);
            Attributes = [7, 10, 13, 2, 12, 4];
            ArmorClass = 10;
            Speed = "10ft, fly 50ft";
            Experience = 10;
            ChallengeLevel = "0";
            Skills = "Perception +3";
            Senses = "passive Perception 13";
            Actions = [
                @"
Beak. Melee Weapon Attack: +2 to hit, reach 5 ft., one target. Hit: 2 (1d4) piercing damage."
            ];
            Abilities = [
                @"
Pack Tactics. The vulture has advantage on an attack roll against a creature if at least one
of the vulture's allies is within 5 feet of the creature and the ally isn't incapacitated.",
                @"
Keen Sight and Smell. The vulture has advantage on Wisdom (Perception) checks that rely on sight or smell."
            ];
        }
    }
}