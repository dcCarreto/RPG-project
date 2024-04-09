using Base;

namespace BestiaryIndex.BestiaryC2
{
    internal class SpinedDevil : Creature
    {

        public SpinedDevil()
        {
            Name = "Spined Devil";
            Type = CreatureTypes.Fiend;
            Size = Sizes.Small;
            Alignment = Alignments.LawfulEvil;
            HitPoints = 22 + RollMultiple(6, 5) + 5;
            ArmorClass = 13;
            Speed = "20ft, fly 40ft";
            AttributeValue = [10, 15, 12, 11, 14, 8];
            ChallengeLevel = "2";
            Experience = 450;
            DamageResistances = "cold, bludgeoning, piercing, and slashing from nonmagical weapons that aren`t silvered";
            DamageImmunities = "fire, poison";
            ConditionImmunities = "poisoned";
            Senses = "darkvision 120ft, passive Perception 12";
            Languages = "Infernal, telepathy 120ft";
            Actions = [
                @"
Multiattack. The devil makes two attacks: one with its bite and
one with its fork or two with its tail spines.",
                @"
Bite. Melee Weapon Attack: +2 to hit, reach 5 ft., one target.
Hit: 5 (2d4) slashing damage.",
                @"
Fork. Melee Weapon Attack: +2 to hit, reach 5 ft ., one target.
Hit: 3 (ld6) piercing damage.",
                @"
Tail Spine. Ranged Weapon Attack: +4 to hit, range 20/80
ft ., one target. Hit: 4 (1d4 + 2) piercing damage plus 3 (ld6)
fire damage."
                ];
            Abilities = [
                @"
Devi/'s Sight. Magical darkness doesn't impede the devil's
darkvision.",
                @"
Flyby. The devil doesn't provoke an opportunity attack when it
flies out of an enemy's reach.",
                @"
Limited Spines. The devil has twelve tail spines. Used spines
regrow by the time the devil finishes a long rest.",
                @"
Magic Resistance. The devil has advantage on saving throws
against spells and other magical effects."
                ];
        }
    }
}
