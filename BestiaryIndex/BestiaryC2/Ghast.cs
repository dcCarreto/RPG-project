using Base;

namespace BestiaryIndex.BestiaryC2
{
    internal class Ghast : Creature
    {

        public Ghast()
        {
            Name = "Ghast";
            Type = CreatureTypes.Undead;
            Size = Sizes.Medium;
            Alignment = Alignments.ChaoticEvil;
            HitPoints = 36 + RollMultiple(8, 8);
            ArmorClass = 13;
            Speed = "30ft";
            AttributeValue = [16, 17, 10, 11, 10, 8];
            ChallengeLevel = "2";
            Experience = 450;
            DamageResistances = "necrotic";
            DamageImmunities = "poison";
            ConditionImmunities = "charmed, exhaustion, poisoned";
            Senses = "darkvision 60ft, passive Perception 10";
            Languages = "Common";
            Actions = [
                @"
Bite. Melee Weapon Attack: +3 to hit, reach 5 ft., one creature.
Hit: 12 (2d8 + 3) piercing damage.",
                @"
Claws. Melee Weapon Attack: +5 to hit, reach 5 ft., one target.
Hit: 10 (2d6 + 3) s lashing damage. If the target is a creature
other than an undead, it must succeed on a DC 10 Constitution
saving throw or be paralyzed for 1 minute. The target can
repeat the saving throw at the end of each of its turns, ending
the effect on itself on a success."
            ];
            Abilities = [
                @"
Stench. Any creature that starts its turn within 5 feet of the
ghast must succeed on a DC 10 Constitution saving throw or
be poisoned until the start of its next turn. On a successfu l
saving throw, the creature is immune to the ghast's Stench
for 24 hours.",
                @"
Turning Defiance. The ghast and any ghouls within 30 feet
of it have advantage on saving throws against effects that
turn undead."
                ];
        }
    }
}
