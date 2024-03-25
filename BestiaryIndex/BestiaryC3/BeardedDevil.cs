using Base;

namespace BestiaryIndex.BestiaryC3
{
    internal class BeardedDevil : Creature
    {
        public BeardedDevil()
        {
            Name = "Bearded Devil";
            Type = Types.Fiend;
            Size = Sizes.Medium;
            Alignment = Alignments.LawfulEvil;
            HitPoints = 52 + RollMultiple(8, 8) + 16;
            ArmorClass = 13;
            Speed = "30ft";
            AttributeValue = [16, 15, 15, 9, 11, 11];
            ChallengeLevel = "3";
            Experience = 700;
            SavingThrows = "Strength +5, Constitution +4, Wisdom +2";
            DamageResistances = "cold, bludgeoning, piercing and slashing from nonmagical weapons that aren`t silvered";
            DamageImmunities = "poisoned";
            ConditionImmunities = "poisoned";
            Senses = "darkvision 120ft, passive Perception 10";
            Languages = "Infernal, telepathy 120ft";
            Actions = [
                @"
Multiattack. The devil makes two attacks: one with its beard
and one with its glaive.",
                @"
Beard. Melee Weapon Attack: +5 to hit, reach 5 ft ., one creature.
Hit: 6 (1d8 + 2) piercing damage, and the target must succeed
on a DC 12 Constitution saving throw or be poisoned for 1
minute. While poisoned in this way, the target can't regain hit
points. The target can repeat the saving throw at the end of
each of its turns, ending the effect on itself on a success.",
                @"
Glaive. Melee Weapon Attack: +5 to hit, reach 10ft., one target.
Hit: 8 (1dl0 + 3) slashing damage. If the target is a creature
other than an undead or a construct, it must succeed on a DC
12 Constitution saving throw or lose 5 (1dl0) hit points at the
start of each of its turns due to an infernal wound. Each time
the devil hits the wounded target with thi s attack, the damage
dealt by the wound increases by 5 (ld10). Any creature can take
an action to stanch the wound with a successful DC 12 Wisdom
(Medicine) check. The wound also closes if the target receives
magical healing."
                ];
            Abilities = [
                @"
Devil's Sight. Magical darkness doesn't impede the devil's
darkvision.",
                @"
Magic Resistance. The devil has advantage on saving throws
again st spells and other magical effects.",
                @"
Steadfast. The devil can 't be frightened whi le it can see an
allied creature within 30 feet of it."
                ];
        }
    }
}
