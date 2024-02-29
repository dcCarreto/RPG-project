using Creatures.Main;

namespace Creatures.BestiaryC0
{
    internal class Baboon : Creatures
    {
        readonly Dices dice = new();
        public Baboon()
        {
            Name = "Baboon";
            Type = ba;
            Size = s;
            Alignment = ud;
            HitPoints = 3 + dice.Roll(6);
            Attributes = [8, 14, 11, 4, 12, 6];
            ArmorClass = 12;
            Speed = "30ft, climb 30ft";
            Experience = 10;
            ChallengeLevel = "0";
            Senses = "passive Perception 11";
            Actions = [
                @"
Bite. Melee Weapon Attack: +1 to hit, reach 5 ft, one target.
Hit: 1 (1d4- 1), piercing damage."
                ];
            Abilities = [
                @"
Pack Tactics. The baboon has advantage on an attack roll against a creature
if at least one of the baboon's allies is within 5 feet of the creature and
the ally isn't incapacitated.",
                ];

        }
    }
}
