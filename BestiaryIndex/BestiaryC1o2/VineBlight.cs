using Base;

namespace BestiaryIndex.BestiaryC1o2
{
    internal class VineBlight : Creature
    {

        public VineBlight()
        {
            Name = "Vine Blight";
            Type = CreatureTypes.Plant;
            Size = Sizes.Medium;
            Alignment = Alignments.NeutralEvil;
            HitPoints = 26 + RollMultiple(8, 4) + 8;
            ArmorClass = 12;
            Speed = "10ft";
            AttributeValue = [15, 8, 14, 5, 10, 3];
            ChallengeLevel = "1/2";
            Experience = 100;
            ConditionImmunities = "blinded, deafened";
            Skills = "Stealth +1";
            Senses = "blindsight 60ft (blind beyond this radius), passive Perception 10";
            Languages = "Common";
            Actions = [
                @"
Constrict. Melee Weapon Attack: +4 to hit, reach 10ft., one
target. Hit: 9 (2d6 + 2) bludgeoning damage, and a Large or
smaller target is grappled (escape DC 12) . Until this grapple
ends, the target is re strained, and the blight can't constrict
another target.",
                @"
Entangling Plants (Recharge 5-6). Grasping roots and vines
sprout in a 15-foot radius centered on the blight, withering
away after 1 minute. For the duration, that area is difficult
terrain for non plant creatures. In addition, each creature
of the blight 's choice in that area when the plants appear
must succeed on a DC 12 Strength saving throw or become
re strained . A creature can use its action to make a DC 12
Strength check, freeing it self or another entangl ed creature
within reach on a success."
                ];
            Abilities = [
                @"
False Appearance. While the blight remains motionless , it is
indi stingu is hable from a tangle of vines."
                ];
        }
    }
}
