namespace Creatures.BestiaryC1
{
    internal class GiantVulture : Creatures
    {
        readonly Dices dice = new();
        public GiantVulture()
        {
            Name = "Giant Vulture";
            Type = ba;
            Size = l;
            Alignment = ne;
            HitPoints = 22 + dice.RollMultiple(dice.d10, 3) + 6;
            ArmorClass = 10;
            Speed = "10ft, fly 60ft";
            Attributes = [15, 10, 15, 6, 12, 7];
            ChallengeLevel = "1";
            Experience = 200;
            Skills = "Perception +3";
            Senses = "passive Perception 13";
            Languages = "understands common but can`t speak";
            Actions = [
                @"
Multiattack. The vulture makes two attacks: one with its beak
and one with its talons.",
                @"
Beak. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 7 (2d4 + 2) p}ercing damage.",
                @"
Talons. Melee Weapon Attack: +4 to hit, reach 5 ft, one target,
Hit: 9 (2d6 + 2) slashing damage."
                ];
            Abilities = [
                @"
Keen Sight and Smell. The vulture has advantage on Wisdom
(Perception) checks that rely on sight or smell.",
                @"
Pack Tactics. The vulture has advantage on an attack roll
against a creature if at least one of the vulture's allies is within
5 feet of the creature and the ally isn't incapacitated."
                ];
        }
    }
}
