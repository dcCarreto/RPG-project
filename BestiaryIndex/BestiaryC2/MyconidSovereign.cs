using Base;

namespace BestiaryIndex.BestiaryC2
{
    internal class MyconidSovereign : Creature
    {

        public MyconidSovereign()
        {
            Name = "Myconid Soverign";
            Type = Types.Plant;
            Size = Sizes.Large;
            Alignment = Alignments.LawfulNeutral;
            HitPoints = 60 + RollMultiple(10, 8) + 16;
            ArmorClass = 13;
            Speed = "30ft";
            AttributeValue = [12, 10, 14, 13, 15, 10];
            ChallengeLevel = "2";
            Experience = 450;
            Senses = "darkvision 120ft, passive Perception 12";
            Actions = [
                @"
Multiattack. The myconid uses either its Hallucination Spores
or its Pacifying Spores, then makes a fist attack.",
                @"
Fist. Melee Weapon Attack: +3 to hit, reach 5 ft., one target. Hit:
8 (3d4 + 1) bludgeoning damage plus 7 (3d4) poison damage.",
                @"
Animating Spores (3fDay). The myconid targets one corpse of
a humanoid or a Large or smaller beast within 5 feet of it and
releases spores at the corpse. In 24 hours, the corpse rises as a
spore servant. The corpse stays animated for 1d4 + 1 weeks or
until destroyed, and it can't be animated again in this way.",
                @"
Hallucination Spores. The myconid ejects spores at one
creature it can see within 5 feet of it. The target must succeed
on a DC 12 Constitution saving throw or be poisoned for
1 minute. The poisoned target is incapacitated while it
hallucinates. The target can repeat the saving throw at the end
of each of its turns, ending the effect on itself on a success.",
                @"
Pacifying Spores. The myconid ejects spores at one creature
it can see within 5 feet of it. The target must succeed on a DC
12 Constitution saving throw or be stunned for 1 minute. The
target can repeat the saving throw at the end of each of its
turns, ending the condition on itself on a success.",
                @"
Rapport Spores. A 30-foot radius of spores extends from the
myconid. These spores can go around corners and affect only
creatures with an Intelligence of2 or higher that aren't undead,
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
