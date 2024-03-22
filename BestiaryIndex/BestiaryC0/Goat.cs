using Base;

namespace BestiaryIndex.BestiaryC0
{
    internal class Goat : Creature
    {

        public Goat()
        {
            Name = "Goat";
            Type = Types.Beast;
            Size = Sizes.Medium;
            Alignment = Alignments.Unaligned;
            HitPoints = 4 + Roll(8);
            AttributeValue = [12, 10, 11, 2, 10, 5];
            ArmorClass = 10;
            Speed = "40ft";
            Experience = 10;
            ChallengeLevel = "0";
            Senses = "passive Perception 10";
            Actions = [
                @"
Ram. Melee Weapon Attack: +3 to hit, reach 5 ft, one target.
Hit: 3 (1d4 + 1) bludgeoning damage.
"
];
            HasMultiAttack = false;
            HasSaveOnAttack = true;
            Abilities = [
                @"
Charge. If the goat moves at least 20 feet straight toward
a target and then hits it with a ram attackon the same turn,
the target takes an extra 2 (1d4) bludgeoning damage. If the
target is a creature, it must succeed on a DC 10 Strength
saving throw or be knocked prone.",
@"
Sure-Footed. The goat has advantage on Strength and Dexterity
saving throws made against effects that would knock it prone."
            ];
            Attacks = 
            [
                new (AttackList.Ram, DamageTypes.Bludgeoning, RangeTypes.Melee, "1d4 + 1", 2, 20, DamageTypes.Bludgeoning, "1d4", 10, AttributeName.Strenght)
            ];
        }
    }
}