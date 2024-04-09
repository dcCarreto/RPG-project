using Base;

namespace BestiaryIndex.BestiaryC1o4
{
    internal class DraftHorse : Creature
    {

        public DraftHorse()
        {
            Name = "Draft Horse";
            Type = CreatureTypes.Beast;
            Size = Sizes.Large;
            Alignment = Alignments.Unaligned;
            HitPoints = 19 + RollMultiple(10, 3) + 3;
            ArmorClass = 10;
            Speed = "40ft";
            AttributeValue = [18, 10, 12, 2, 11, 7];
            ChallengeLevel = "1/4";
            Experience = 50;
            Senses = "passive Perception 10";
            Actions = [
                @"
Hooves. Melee Weapon Attack: +6 to hit, reach 5 ft, one target.
Hit: 9 (2d4 + 4) bludgeoning damage."
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Attacks = [
                new(ActionList.Hooves, DamageTypes.Bludgeoning, RangeTypes.Melee, "2d4 + 4")
                ];
        }
    }
}
