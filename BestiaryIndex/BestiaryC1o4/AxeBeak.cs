using Base;

namespace BestiaryIndex.BestiaryC1o4
{
    internal class AxeBeak : Creature
    {

        public AxeBeak()
        {
            Name = "Axe Beak";
            Type = Types.Beast;
            Size = Sizes.Large;
            Alignment = Alignments.Unaligned;
            HitPoints = 19 + RollMultiple(10, 3) + 3;
            ArmorClass = 11;
            Speed = "50ft";
            AttributeValue = [14, 12, 12, 2, 10, 5];
            ChallengeLevel = "1/4";
            Experience = 50;
            Senses = "passive PErception 10";
            Actions = [
                @"
Beak. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 6 (1d8 + 2) slashing damage."
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Attacks =
                [
                new(AttackList.Beak, DamageTypes.Slashing, RangeTypes.Melee, "1d8 + 2")
                ];
        }
    }
}
