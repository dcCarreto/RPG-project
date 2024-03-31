using Base;

namespace BestiaryIndex.BestiaryC1o4
{
    internal class RidingHorse : Creature
    {

        public RidingHorse()
        {
            Name = "Riding Horse";
            Type = Types.Beast;
            Size = Sizes.Large;
            Alignment = Alignments.Unaligned;
            HitPoints = 13 + RollMultiple(10, 2) + 2;
            ArmorClass = 10;
            Speed = "60ft";
            AttributeValue = [16, 10, 12, 2, 11, 7];
            ChallengeLevel = "1/4";
            Experience = 50;
            Senses = "passive Perception 10";
            Actions = [
                @"
Hooves. Melee Weapon Attack: +2 to hit, reach 5 ft ., one target.
Hit: 8 (2d4 + 3) bludgeoning damage."
                ];
            Attacks =
                [
                new(ActionList.Hooves, DamageTypes.Bludgeoning, RangeTypes.Melee, "2d4 + 3")
                ];
        }
    }
}
