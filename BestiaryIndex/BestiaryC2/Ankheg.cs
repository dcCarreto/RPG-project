using Base;

namespace BestiaryIndex.BestiaryC2
{
    internal class Ankheg : Creature
    {

        public Ankheg()
        {
            Name = "Ankheg";
            Type = Types.Monstruosity;
            Size = Sizes.Large;
            Alignment = Alignments.Unaligned;
            HitPoints = 39 + RollMultiple(10, 6) + 6;
            ArmorClass = 14;
            Speed = "30ft, burrow 10ft";
            AttributeValue = [17, 11, 13, 1, 13, 6];
            ChallengeLevel = "2";
            Experience = 450;
            Senses = "darkvision 60ft, tremorsense 60ft";
            Actions = [
                @"
Bite. Melee Weapon Attack: +5 to hit, reach 5 ft., one target.
Hit: 9 (2d6 + 3) slashing damage plus 3 (1d6) acid damage. If
the target is a Large or smaller creature, it is grappled (escape
DC 13). Until this grapple ends, the ankheg can bite only the
grappled creature and has advantage on attack rolls to do so.",
                @"
Acid Spray (Recharge 6). The ankheg spits acid in a line that is
30 feet long and 5 feet wide, provided that it has no creature
grappled. Each creature in that line must make a DC 13
Dexterity saving throw, taking 10 (3d6) acid damage on a failed
save, or half as much damage on a successful one."
                ];
        }
    }
}
