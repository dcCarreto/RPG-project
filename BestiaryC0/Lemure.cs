using Creatures.CombatAttributes;

namespace Creatures.BestiaryC0
{
    internal class Lemure : Creature
    {

        public Lemure()
        {
            Name = "Lemure";
            Type = Types.Fiend;
            Size = Sizes.Medium;
            Alignment = Alignments.LawfulEvil;
            HitPoints = 13 + RollMultiple(8, 3);
            Attributes = [10, 5, 11, 1, 11, 3];
            ArmorClass = 7;
            Speed = "15ft";
            Experience = 10;
            ChallengeLevel = "0";
            DamageResistances = "cold";
            DamageImmunities = "fire, poison";
            ConditionImmunities = "charmed, frightened, poisoned";
            Senses = "darkvision 120ft, passive Perception 10";
            Languages = "Understands Infernal but can't speak";
            Actions = [
                @"
Fist. Melee Weapon Attack: +3 to hit, reach 5ft, one target.
Hit: 2 (1d4) bludgeoning damage."
            ];
            Abilities = [
                @"
Hellish Rejuvenation. A lemure that dies in the Nine Hells comes back
to life with all its hit points in 1d10 days unless it is killed by a
good·aligned creature with a bless spell cast on that creature or its
remains are sprinkled with holy water.",
                @"
Devil's Sight. Magical darkness doesn't impede the lemure's darkvision."
            ];
            Attacks = new List<Attack>
            {
                new Attack ( AttackList.Fist, DamageTypes.Bludgeoning, RangeTypes.Melee, "1d4" )
            };
        }
    }
}
