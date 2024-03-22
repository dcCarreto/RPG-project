using Base;

namespace BestiaryIndex.BestiaryC1
{
    internal class AnimatedArmor : Creature
    {

        public AnimatedArmor()
        {
            Name = "Animated Armor";
            Type = Types.Construct;
            Size = Sizes.Medium;
            Alignment = Alignments.Unaligned;
            HitPoints = 33 + RollMultiple(8, 6) + 6;
            ArmorClass = 18;
            Speed = "25ft";
            AttributeValue = [14, 11, 13, 1, 3, 1];
            ChallengeLevel = "1";
            Experience = 200;
            DamageImmunities = "poison, psychic";
            ConditionImmunities = "blinded, charmed, deafened, exhaustion, frightened, paralyzed, petrified, poisoned";
            Senses = "blindsight 60ft (blind beyond this radius), passive Perception 6";
            Actions = [
                @"
Multiattack. The armor makes two melee attacks.",
                @"
Slam. Melee Weapon Attack: +4 to hit, reach 5 ft ., one target.
Hit: 5 (1d6 + 2) bludgeoning damage."
                ];
            Abilities = [
                @"
Antimagic Susceptibility. The armor is incapacitated while in
the area of an anti magic field. If targeted by dispel magic, the
armor must succeed on a Constitution saving throw against the
caster's spell save DC or fall unconscious for 1 minute.",
                @"
False Appearance. While the armor remains motion less, it is
indistinguishable from a normal suit of armor."
                ];
            hasMultiAttack = true;
            Attacks =
            [
                new(AttackList.Slam, DamageTypes.Bludgeoning, RangeTypes.Melee, "1d6 + 2")
            ];

        }
    }
}
