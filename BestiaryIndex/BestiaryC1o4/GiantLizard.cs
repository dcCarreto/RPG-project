using Base;

namespace BestiaryIndex.BestiaryC1o4
{
    internal class GiantLizard : Creature
    {

        public GiantLizard()
        {
            Name = "Giant Lizard";
            Type = Types.Beast;
            Size = Sizes.Large;
            Alignment = Alignments.Unaligned;
            HitPoints = 19 + RollMultiple(10, 3) + 3;
            ArmorClass = 12;
            Speed = "30ft, climb 30ft";
            AttributeValue = [15, 12, 13, 2, 10, 5];
            ChallengeLevel = "1/4";
            Experience = 50;
            Senses = "darkvision 30ft, passive Perception 10";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft, one target.
Hit: 6 (1d8 + 2) piercing damage."
                ];
            Abilities = [
                @"
Hold Breath. The lizard can hold its breath for 15 minutes.
(A lizard that has this trait also has a swimming speed
of 30 feet.)",
                @"
Spider Climb. The lizard can climb difficult surfaces,
including upside down on ceilings, without needing to make
an ability check."
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Attacks =
                [
                new(ActionList.Bite, DamageTypes.Piercing, RangeTypes.Melee, "1d8 + 2")
                ];
        }
    }
}
