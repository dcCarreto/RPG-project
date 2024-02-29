using Creatures.Main;

namespace Creatures.BestiaryC0
{
    internal class Goat : Creatures
    {
        readonly Dices dice = new();
        public Goat()
        {
            Name = "Goat";
            Type = ba;
            Size = m;
            Alignment = ud;
            HitPoints = 4 + dice.Roll(8);
            Attributes = [12, 10, 11, 2, 10, 5];
            ArmorClass = 10;
            Speed = "40ft";
            Experience = 10;
            ChallengeLevel = "0";
            Senses = "passive Perception 10";
            Actions = [
                @"
Ram. Melee Weapon Attack: +3 to hit, reach 5 ft, one target.
Hit: 3 (1d4 + 1) bludgeoning damage.
"
];
            Abilities = [
                @"
Charge. If the goat moves at least 20 feet straight toward
a target and then hits it with a ram attackon the same turn,
the target takes an extra 2 (1d4) bludgeoning damage. If the
target is a creature, it must succeed on a DC 10 Strength
saving throw or be knocked prone.",
@"
Sure-Footed. The goat has advantage on Strength and Dexterity
saving throws made against effects that would knock it prone."
            ];
        }
    }
}