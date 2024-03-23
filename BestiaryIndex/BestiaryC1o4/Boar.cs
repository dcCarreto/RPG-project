using Base;

namespace BestiaryIndex.BestiaryC1o4
{
    internal class Boar : Creature
    {

        public Boar()
        {
            Name = "Boar";
            Type = Types.Beast;
            Size = Sizes.Medium;
            Alignment = Alignments.Unaligned;
            HitPoints = 11 + RollMultiple(8, 2) + 2;
            ArmorClass = 11;
            Speed = "40ft";
            AttributeValue = [13, 11, 12, 2, 9, 5];
            ChallengeLevel = "1/4";
            Experience = 50;
            Senses = "passive Perception 9";
            Actions = [
                @"
Tusk. Melee Weapon Attack: +3 to hit, reach 5 ft, one target.
Hit: 4 (1d6 + 1) slashing damage."
                ];
            Abilities = [
                @"
Charge. If the boar moves at least 20 feet straight toward a ·
target and then hits it with a tusk attack on the same turn, the
target takes an extra 3 (1 6) slashing damage. If the target is a
creature, it must succeed on a DC 11 Strength saving throw or
be knocked prone.",
                @"
Relentless (Recharges after a Short or Long Rest). If the boar
takes 7 damage or less that would reduce it to 0 hit points, it is
reduced to 1 hit point instead."
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Attacks =
                [
                new(AttackList.Tusk, DamageTypes.Slashing, RangeTypes.Melee, "1d6 + 1")
                ];

        }
    }
}
