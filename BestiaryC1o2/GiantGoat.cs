namespace Creatures.BestiaryC1o2
{
    internal class GiantGoat : Creatures
    {
        readonly Dices dice = new();
        public GiantGoat()
        {
            Name = "Giant Goat";
            Type = ba;
            Size = l;
            Alignment = ud;
            HitPoints = 19 + dice.RollMultiple(dice.d10, 3) + 3;
            ArmorClass = 11;
            Speed = "40ft";
            Attributes = [17, 11, 12, 3, 12, 6];
            ChallengeLevel = "1/2";
            Experience = 100;
            Senses = "passive Perception 11";
            Actions = [
                @"
Ram. Melee Weapon Attack: +5 to hit, reach 5 ft., one target.
Hit: 8 (2d4 + 3) bludgeoning damage."
                ];
            Abilities = [
                @"
Charge. If the goat moves at least 20 feet straight toward a
target and then hits it with a ram attack on the same turn , the
target takes an extra 5 (2d4) bludgeoning damage. If the target
is a creature, it must succeed on a DC 13 Strength saving throw
or be knocked prone.",
                @"
Sure-Footed. The goat has advantage on Strength and Dexterity
saving throws made against effects that would knock it prone."
                ];
        }
    }
}
