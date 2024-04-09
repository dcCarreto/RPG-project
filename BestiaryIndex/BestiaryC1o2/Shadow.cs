using Base;

namespace BestiaryIndex.BestiaryC1o2
{
    internal class Shadow : Creature
    {

        public Shadow()
        {
            Name = "Shadow";
            Type = CreatureTypes.Undead;
            Size = Sizes.Medium;
            Alignment = Alignments.ChaoticEvil;
            HitPoints = 16 + RollMultiple(8, 3) + 3;
            ArmorClass = 12;
            Speed = "40ft";
            AttributeValue = [6, 14, 13, 6, 10, 8];
            ChallengeLevel = "1/2";
            Experience = 100;
            DamageVulnerabilities = "radiant";
            DamageResistances = "acid, cold, fire, lightning, thunder, bludgeoning, piercing, and slashing from nonmagical weapons";
            DamageImmunities = "necrotic, poison";
            ConditionImmunities = "exhaustion, frightened, grappled, paralyzed, petrified, poisoned, prone, restrained";
            Skills = "Stealth +4 (+6 in dim light or darkness)";
            Senses = "darkvision 60ft, passive Perception 10";
            Actions = [
                @"
Strength Drain. Melee Weapon Attack: +4 to hit, reach 5 ft.,
one creature. Hit: 9 (2d6 + 2) necrotic damage, and the target's
Strength score is reduced by 1d4. The target dies if this reduces
its Strength to 0. Otherwise, the reduction lasts until the target
finishes a short or long rest.
If a non-evil humanoid dies from this attack, a new shadow
rises from the corpse 1d4 hours later."
                ];
            Abilities = [
                @"
Amorphous. The shadow can move through a space as narrow
as 1 inch wide without squeezing.",
                @"
Shadow Stealth. While in dim light or darkness, the shadow
can take the Hide action as a bonus action.",
                @"
Sunlight Weakness. While in sunlight, the shadow has
disadvantage on attack rolls, ability checks, and saving throws."
                ];

        }
    }
}
