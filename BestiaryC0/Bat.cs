namespace Creatures.BestiaryC0
{
    internal class Bat : Creatures
    {
        readonly Dices dice = new();
        public Bat ()
        {
            Name = "Bat";
            Type = ba;
            Size = t;
            Alignment = ud;
            HitPoints = 1 + (dice.Roll(dice.d4) - 1);
            Attributes = [2, 15, 8, 2, 12, 4];
            ArmorClass = 12;
            Speed = "5ft, fly 30ft";
            Experience = 10;
            ChallengeLevel = "0";
            Senses = "blindsight 60ft, passive Perception 11";
            Actions = [
                @"
Bite. Melee Weapon Attack: +0 to hit, reach 5ft, one creature.
Hit: 1 piercing damage."
                ];
            Abilities = [
                @"
Keen Hearing. The bat has advantage on Wisdom (Perception) checks that rely on hearing.",
                @"
Echolocation. The bat can't use its blind sight while deafened."
            ];

        }
    }
}
