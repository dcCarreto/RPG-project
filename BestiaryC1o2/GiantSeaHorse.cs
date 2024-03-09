namespace Creatures.BestiaryC1o2
{
    internal class GiantSeaHorse : Creature
    {

        public GiantSeaHorse()
        {
            Name = "Giant Sea Horse";
            Type = Types.Beast;
            Size = Sizes.Large;
            Alignment = Alignments.Unaligned;
            HitPoints = 16 + RollMultiple(10, 3);
            ArmorClass = 13;
            Speed = "0ft, swim 40ft";
            Attributes = [12, 15, 11, 2, 12, 5];
            ChallengeLevel = "1/2";
            Experience = 100;
            Senses = "passive Perception 11";
            Actions = [
                @"
Ram. Melee Weapon Attack: +3 to hit, reach 5 ft., one target.
Hit: 4 (1d6 + 1) bludgeoning damage."
                ];
            Abilities = [
                @"
Charge. If the sea horse moves at least 20 feet straight toward
a target and then hits it with a ram attack on the same turn , the
target takes an extra 7 (2d6) bludgeoning damage. It the target
is a creature, it must succeed on a DC 11 Strength saving throw
or be knocked prone.",
                @"
Water Breathing. The sea horse can breathe only underwater."
                ];
        }
    }
}
