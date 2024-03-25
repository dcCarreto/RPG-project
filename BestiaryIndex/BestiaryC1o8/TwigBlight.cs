using Base;

namespace BestiaryIndex.BestiaryC1o8
{
    internal class TwigBlight : Creature
    {

        public TwigBlight()
        {
            Name = "Twig Blight";
            Type = Types.Plant;
            Size = Sizes.Small;
            Alignment = Alignments.NeutralEvil;
            HitPoints = 4 + Roll(6) + 1;
            ArmorClass = 13;
            Speed = "20ft";
            AttributeValue = [6, 13, 12, 4, 8, 3];
            ChallengeLevel = "1/8";
            Experience = 25;
            DamageVulnerabilities = "fire";
            ConditionImmunities = "blinded, deafened";
            Skills = "Stealth +3";
            Senses = "blindsight 60ft (blind beyond this radius), passive Perception 9";
            Actions = [
                @"
Claws. Melee Weapon Attack: +3 to hit, reach 5 ft, one target.
Hit: 3 (1d4 + 1) piercing damage."
                ];

            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Abilities = [
                @"
False Appearance. While the blight remains motionl ess, it is
indistingui shable from a dead shrub."
                ];
            Attacks =
                [
                new(ActionList.Claws, DamageTypes.Piercing, RangeTypes.Melee, "1d4 + 1")
                ];
        }
    }
}
