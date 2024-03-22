using Base;

namespace BestiaryIndex.BestiaryC1o8
{
    internal class Manes : Creature
    {

        public Manes()
        {
            Name = "Manes";
            Type = Types.Fiend;
            Size = Sizes.Small;
            Alignment = Alignments.ChaoticEvil;
            HitPoints = 9 + RollMultiple(6, 2) + 2;
            AttributeValue = [10, 9, 13, 3, 8, 4];
            ArmorClass = 9;
            Speed = "20ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            DamageResistances = "cold, fire, lightning";
            DamageImmunities = "poison";
            ConditionImmunities = "Charmed, Frightened, Poisoned";
            Senses = "darkvision 60ft, passive Perception 9";
            Languages = "understands Abyssal but can't speak";
            Actions = [
                @"
Claws. Melee Weapon Attack: +2 to hit, reach 5 ft., one target.
Hit: 5 (2d4) slashing damage."
                ];

            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Attacks =
            [
                new(AttackList.Claws, DamageTypes.Slashing,RangeTypes.Melee, "2d4")

            ];
        }
    }
}