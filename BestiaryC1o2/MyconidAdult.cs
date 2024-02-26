namespace Creatures.BestiaryC1o2
{
    internal class MyconidAdult : Creatures
    {
        readonly Dices dice = new();
        public MyconidAdult()
        {
            Name = "Myconid Adult";
            Type = pl;
            Size = m;
            Alignment = ln;
            HitPoints = 22 + dice.RollMultiple(dice.d8, 4) + 4;
            ArmorClass = 12;
            Speed = "20ft";
            Attributes = [10, 10, 12, 10, 13, 7];
            ChallengeLevel = "1/2";
            Experience = 100;
            Senses = "darkvision 120ft, passive Perception 11";
            Actions = [
                @"
Fist. Melee Weapon Attack: +2 to hit, reach 5 ft., one target. Hit:
5 (2d4) bludgeoning damage plus 5 (2d4) poison damage.",
                @"
Pacifying Spores (3fDay). The myconid ejects spores at one
creature it can see within 5 feet of it. The target must succeed
on a DC 11 Constitution saving throw or be stunned for 1
minute. The target can repeat the saving throw at the end of
each of its turns, ending the effect on itself on a success.",
                @"
Rapport Spores. A 20-foot radius of spores extends from the
myconid. These spores can go around corners and affect only
creatures with an Intelligence of 2 or higher that aren't undead,
constructs, or elementals. Affected creatures can communicate
telepathically with one another while they are within 30 feet of
each other. The effect lasts for 1 hour."
                ];
            Abilities = [
                @"
Distress Spores. When the myconid takes damage, all other
myconids within 240 feet of it can sense its pain.",
                @"
Sun Sickness. While in sunlight, the myconid has disadvantage
on ability checks, attack rolls, and saving throws. The myconid
dies if it spends more than 1 hour in direct sunlight."
                ];
        }
    }
}
