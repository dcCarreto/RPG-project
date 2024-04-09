using Base;

namespace BestiaryIndex.BestiaryC2
{
    internal class GiantConstrictorSnake : Creature
    {
        public GiantConstrictorSnake()
        {
            Name = "Giant Constrictor Snake";
            Type = CreatureTypes.Beast;
            Size = Sizes.Huge;
            Alignment = Alignments.Unaligned;
            HitPoints = 60 + RollMultiple(12, 8) + 8;
            ArmorClass = 12;
            Speed = "30ft, swim 30ft";
            AttributeValue = [19, 14, 12, 1, 10, 3];
            ChallengeLevel = "2";
            Experience = 450;
            Skills = "Perception +2";
            Senses = "blindsight 10ft, passive Perception 12";
            Actions = [
                @"
Bite. Melee Weapon Attack: +6 to hit, reach 10ft., one creature.
Hit: 11 (2d6 +4) piercing damage.",
                @"
Constrict. Melee Weapon Attack: +6 to hit, reach 5 ft, one
creature. Hit: 13 (2d8 + 4) bludgeoning damage, and the
target is grappled (escape DC 16). Until this grapple ends,
the creature is restrained, and the snake can't constrict
another target."
                ];
        }
    }
}
