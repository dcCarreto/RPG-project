using Base;

namespace BestiaryIndex.BestiaryC1o8
{
    internal class GiantCrab : Creature
    {

        public GiantCrab()
        {
            Name = "Giant Crab";
            Type = Types.Beast;
            Size = Sizes.Medium;
            Alignment = Alignments.Unaligned;
            HitPoints = 13 + RollMultiple(8, 3);
            AttributeValue = [13, 15, 11, 1, 9, 3];
            ArmorClass = 15;
            Speed = "30ft, swim 30ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Skills = "Stealth +4";
            Senses = "blindsight 30ft, passive Perception 9";
            Actions = [
                @"
 Claw. Melee Weapon Attack: +3 to hit, reach 5ft, one target.
 Hit: 4 (1d6 + 1) bludgeoning damage, and the target is 
 grappled (escape DC 11). The crab has two claws, each of
 which can grapple only one target."
                ];
            Abilities = [
                @"               
Amphibious. The crab can breath air and water."
            ];
            HasMultiAttack = false;
            HasSaveOnAttack = true;
            Attacks =
            [
                new(AttackList.Claws, DamageTypes.Bludgeoning,RangeTypes.Melee, "1d6 + 1", 4, 5, DamageTypes.Bludgeoning, "1d1", 11, AttributeName.Constitution)

            ];
        }
    }
}