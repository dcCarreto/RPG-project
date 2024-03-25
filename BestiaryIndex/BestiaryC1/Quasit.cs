using Base;
namespace BestiaryIndex.BestiaryC1
{
    internal class Quasit : Creature
    {

        public Quasit()
        {
            Name = "Quasit";
            Type = Types.Fiend;
            Size = Sizes.Tiny;
            Alignment = Alignments.ChaoticEvil;
            HitPoints = 7 + RollMultiple(4, 3);
            ArmorClass = 13;
            Speed = "40ft";
            AttributeValue = [5, 17, 10, 7, 10, 10];
            ChallengeLevel = "1";
            Experience = 200;
            DamageResistances = "cold, fire, lightning, bludgeoning, piercing, slashing from nonmagical weapons";
            DamageImmunities = "poison";
            ConditionImmunities = "poisoned";
            Skills = "Stealth +5";
            Senses = "darkvision 120ft, passive Perception 10";
            Languages = "Abyssal, Common";
            Actions = [
                @"
Claws (Bite in Beast Form). Melee Weapon Attack: +4 to hit,
reach 5 ft ., one target. Hit: 5 (1d4 + 3) piercing damage, and
the target must succeed on a DC 10 Constitution saving throw
or take 5 (2d4) poison damage and become poisoned for 1
minute. The target can repeat the saving throw at the end of
each of its turns, ending the effect on itse lf on a success.",
                @"
Scare (1/Day). One creature ofthe quasit's choice within 20
feet of it must succeed on a DC 10 Wisdom saving throw or be
frightened for 1 minute. The target can repeat the saving throw
at the end of each of its turns, with disadvantage if the quasit is
within line of sight, ending the effect on itself on a success.",
                @"
Invisibility. The quasit magically turns invisible until it
attacks or uses Scare, or until its concentration ends (as if
concentrating on a spell) . Any equipment the qu asit wears or
carries is invisible with it."
                ];
            Abilities = [
                @"
Shapechanger. The quasit can use its action to polymorph into
a beast form that resembles a bat (speed 10ft. fly 40ft.), a
centipede (40ft., climb 40ft.), or a toad (40ft., swim 40ft.),
or back into its true form. Its stati stics are the same in each
form, except for th e speed changes noted. Any equ ipment it is
wearing or carrying isn't transformed . It reverts to its true form
if it dies.",
                @"
Magic Resistance. The quasit has advantage on saving throws
against spells and other magical effects."
                ];

        }
    }
}
