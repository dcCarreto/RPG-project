namespace Creatures.BestiaryC1
{
    internal class Imp : Creatures
    {
        readonly Dices dice = new();
        public Imp()
        {
            Name = "Imp";
            Type = fi;
            Size = t;
            Alignment = le;
            HitPoints = 10 + dice.RollMultiple(dice.d4, 3) + 3;
            ArmorClass = 13;
            Speed = "20ft, fly 40ft";
            Attributes = [6, 17, 13, 11, 12, 14];
            ChallengeLevel = "1";
            Experience = 200;
            DamageResistances = "cold, bludgeoning, piercing, and slashing from nonmagical weapons that aren't silvered";
            DamageImmunities = "fire, poison";
            ConditionImmunities = "poisoned";
            Skills = "Deception +4, Insight +3, Persuasion +4, Stealth +5";
            Senses = "darkvision 120ft, passive Perception 11";
            Languages = "Infernal, Common";
            Actions = [
                @"
Sting (Bite in Beast Form). Melee Weapon Attack: +5 to hit,
reach 5 ft ., one target. Hit: 5 (1d4 + 3) piercing damage, and
the target must make on a DC 11 Constitution saving throw,
taking 10 (3d6) poison damage on a failed save, or half as
much damage on a successful one.",
                @"
Invisibility. The imp magically turns invi sib le until it attacks or
until its concentration ends (as if concentrating on a spell). Any
equipment the imp wears or carries is invisible with it."
                ];
            Abilities = [
                @"
Shapechanger. The imp can use its action to polymorph into a
beast form that resembles a rat (speed 20ft.), a raven (20ft.,
fly 60ft.), or a spider (20ft., climb 20ft.), or back into its true
form. Its stati stics are the same in each form, except for the
speed changes noted. Any equipment it is wearing or carrying
isn't transformed. It reverts to its true form if it dies.",
                @"
Devil's Sight. Magical darkness doesn't impede the imp's
darkvision.",
                @"
Magic Resistance. The imp has advantage on saving throws
against spells and other magical effects."
                ];
        }
    }
}
