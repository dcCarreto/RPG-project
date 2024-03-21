namespace Base.BestiaryC1
{
    internal class Specter : Creature
    {

        public Specter()
        {
            Name = "Specter";
            Type = Types.Undead;
            Size = Sizes.Medium;
            Alignment = Alignments.ChaoticEvil;
            HitPoints = 22 + RollMultiple(8, 5);
            ArmorClass = 12;
            Speed = "0ft, fly 50ft (hover)";
            Attributes = [1, 14, 11, 10, 10, 11];
            ChallengeLevel = "1";
            Experience = 200;
            DamageResistances = "acid, cold, fire, lightning, thunder, bludgeoning, piercing, and slashing from nonmagical weapons";
            DamageImmunities = "necrotic, poison";
            ConditionImmunities = "charmed, exhaustion, grappled, paralyzed, petrified, poisoned, prone, restrained, unconscious";
            Senses = "darkvision 60ft, passive Perception 10";
            Languages = "understands all languages it knew in life but can`t speak";
            Actions = [
                @"
Life Drain. Melee Spell Attack: +4 to hit, reach 5 ft. , one
creature. Hit: 10 (3d6) necrotic damage. The target must
succeed on a DC 10 Constitution saving throw or its hit point
maximum is reduced by an amount equal to the damage taken.
This reduction lasts until the creature finishes a long rest. The
target dies if this effect reduces its hit point maximum to 0."
                ];
            Abilities = [
                @"
Incorporeal Movement. The specter can move through other
creatures and objects as if they were difficult terrain. It takes 5
(1d10) force damage if it ends its turn ins ide an object.",
@"
Sunlight Sensitivity. While in sunlight, the specter has
disadvantage on attack rolls, as well as on Wisdom
(Perception) checks that rely on sight."
                ];
        }
    }
}
