namespace Creatures.BestiaryC1
{
    internal class Scarecrow : Creature
    {

        public Scarecrow()
        {
            Name = "Scarecrow";
            Type = co;
            Size = m;
            Alignment = ce;
            HitPoints = 36 + RollMultiple(8, 8);
            ArmorClass = 11;
            Speed = "30ft";
            Attributes = [11, 13, 11, 10, 10, 13];
            ChallengeLevel = "1";
            Experience = 200;
            Actions = [@"
Multiattack. The scarecrow makes two claw attacks.",
                @"
Claw. Melee Weapon Attack: +3 to hit, reach 5 ft., one target.
Hit: 6 (2d4 + 1) slashing damage. If the target is a creature,
it must succeed on a DC 11 Wisdom saving throw or be
frightened until the end of the scarecrow's next turn.",
                @"
Terrifying Glare. The scarecrow targets one creature it can
see within 30 feet of it. If the target can see the scarecrow, the
target must succeed on a DC 11 Wisdom saving throw or be
magically frightened until the end of the scarecrow's next turn.
The frightened target is paralyzed."
];
            Abilities = [
                @"
False Appearance. While the scarecrow remains motionless, it
is indistinguishable from an ordinary, inanimate scarecrow."
                ];
        }
    }
}
