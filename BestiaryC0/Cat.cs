namespace Creatures.BestiaryC0
{
    internal class Cat : Creatures
    {

        public Cat()
        {
            Name = "Cat";
            Type = ba;
            Size = t;
            Alignment = ud;
            HitPoints = 2 + Roll(4);
            Attributes = [3, 15, 10, 3, 12, 7];
            ArmorClass = 12;
            Speed = "40ft, climb 30ft";
            Experience = 10;
            ChallengeLevel = "0";
            Skills = "Perception +3, Stealth +4";
            Senses = "passive Perception 13";
            Actions = [
                @"
Claws. Melee Weapon Attack: +0 to hit, reach 5 ft, one target.
Hit: 1 slashing damage."
                ];
            Abilities = [
                @"
Keen Smell. The cat has advantage on Wisdom (Perception) checks that rely on smell."
                ];
        }
    }
}
