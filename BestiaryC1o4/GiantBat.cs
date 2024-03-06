namespace Creatures.BestiaryC1o4
{
    internal class GiantBat : Creature
    {

        public GiantBat()
        {
            Name = "Giant Bat";
            Type = ba;
            Size = l;
            Alignment = ud;
            HitPoints = 22 + RollMultiple(10, 4);
            ArmorClass = 13;
            Speed = "10ft, fly 60ft";
            Attributes = [15, 16, 11, 2, 12, 6];
            ChallengeLevel = "1/4";
            Experience = 50;
            Senses = "blindsight 60ft, passive Perception 11";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft, one creature.
Hit: 5 (1d6 + 2) piercing damage."
                ];
            Abilities = [
                @"
Echolocation. The bat can't use its blindsight while deafened.",
                @"
Keen Hearing. The bat has advantage on Wisdom (Perception) checks
that on hearing."
                ];

        }
    }
}
