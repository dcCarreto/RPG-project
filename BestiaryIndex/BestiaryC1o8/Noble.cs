using Base;

namespace BestiaryIndex.BestiaryC1o8
{
    internal class Noble : Creature
    {

        public Noble()
        {
            Name = "Noble";
            Type = Types.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.AnyAlignment;
            HitPoints = 9 + RollMultiple(8, 2);
            AttributeValue = [11, 12, 11, 12, 14, 16];
            ArmorClass = 15;
            Speed = "30ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Skills = "Deception +5, Insight +4, Persuasion +5";
            Senses = "passive Perception 10";
            Languages = "any two languages";
            Actions = [
                @"
Rapier. Melee Weapon Attack: +3 to hit, reach 5ft, one target.
Hit 5 (1d8 + 1) piercing damage."
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Reactions = @"
Parry. The noble adds 2 to its AC aga inst one melee attack that
would hit it. To do so, the noble must see the attacker and be
wielding a melee weapon.";
            Attacks = [
                new(AttackList.Rapier, DamageTypes.Piercing, RangeTypes.Melee, "1d8 + 1")
                ];
        }
    }
}