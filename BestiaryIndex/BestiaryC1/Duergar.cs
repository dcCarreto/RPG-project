using Base;
namespace BestiaryIndex.BestiaryC1
{
    internal class Duergar : Creature
    {

        public Duergar()
        {
            Name = "Duergar";
            Type = Types.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.LawfulEvil;
            HitPoints = 26 + RollMultiple(8, 4) + 8;
            ArmorClass = 16;
            Speed = "25ft";
            AttributeValue = [14, 11, 14, 11, 10, 9];
            ChallengeLevel = "1";
            Experience = 200;
            Languages = "Dwarvish, Undercommon";
            DamageResistances = "poison";
            Senses = "darkvision 120ft, passive Perception 10";
            Actions = [
                @"
Enlarge (Recharges after a Short or Long Rest). For 1 minute,
the duergar magically increases in size, along with anything it
is wearing or carrying. While enlarged, the duergar is Large,
doubles its damage dice on Strength-based weapon attacks
(included in the attacks), and makes Strength checks and
Strength saving throws with advantage. If the duergar lacks the
room to become Large, it attains the maximum size possible in
the space available.",
                @"
War Pick. Melee Weapon Attack: +4 to hit, reach 5 ft., one
target. Hit: 6 (1d8 + 2) piercing damage, or 11 (2d8 + 2)
piercing damage while enlarged.",
                @"
Javelin. Melee or Ranged Weapon Attack: +4 to hit, reach 5 ft. or
range 30/120 ft., one target. Hit: 5 (1d6 + 2) piercing damage,
or 9 (2d6 + 2) piercing damage while enlarged.",
                @"
Invisibility (Recharges after a Short or Long Rest). The duergar
magically turns invisible until it attacks, casts a spell, or uses
its Enlarge, or until its concentration is broken, up to 1 hour (as
if concentrating on a spell). Any equipment the duergar wears
or carries is invisible with it ."
                ];
            Abilities = [
                @"
Duergar Resilience. The duergar has advantage on saving
throws against poison, spells, and illusions, as well as to resist
being charmed or paralyzed.",
@"
Sunlight Sensitivity. While in sunlight, the duergar has
disadvantage on attack rolls, as well as on Wisdom
(Perception) checks that rely on sight."
                ];


        }
    }
}
