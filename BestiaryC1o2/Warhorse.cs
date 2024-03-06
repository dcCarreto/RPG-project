namespace Creatures.BestiaryC1o2
{
    internal class Warhorse : Creature
    {

        public Warhorse()
        {
            Name = "Warhorse";
            Type = ba;
            Size = l;
            Alignment = ud;
            HitPoints = 19 + RollMultiple(10, 3) + 3;
            ArmorClass = 11;
            Speed = "60ft";
            Attributes = [18, 12, 13, 2, 12, 7];
            ChallengeLevel = "1/2";
            Experience = 100;
            Senses = "passive Perception 11";
            Actions = [
                @"
Hooves. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 11 (2d6 + 4) bludgeoning damage."
                ];
            Abilities = [
                @"
Trampling Charge. If the horse moves at least 20 feet stra ight
toward a creature and then hits it with a hooves attack on
the same turn, that target must succeed on a DC 14 Strength
saving throw or be knocked prone. If the target is prone, the
horse can make another attack with its hooves against it as a
bonus action ."
                ];
        }
    }
}
