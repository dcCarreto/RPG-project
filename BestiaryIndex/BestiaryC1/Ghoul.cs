using Base;
namespace BestiaryIndex.BestiaryC1
{
    internal class Ghoul : Creature
    {

        public Ghoul()
        {
            Name = "Ghoul";
            Type = Types.Undead;
            Size = Sizes.Medium;
            Alignment = Alignments.ChaoticEvil;
            HitPoints = 22 + RollMultiple(8, 5);
            ArmorClass = 12;
            Speed = "30ft";
            AttributeValue = [13, 15, 10, 7, 10, 6];
            ChallengeLevel = "1";
            Experience = 200;
            DamageImmunities = "poison";
            ConditionImmunities = "charmed, exhaustion, poisoned";
            Senses = "darkvision 60ft, passive Perception 10";
            Languages = "Common";
            Actions = [
                @"
Bite. Melee Weapon Attack: +2 to hit, reach 5 ft., one creature.
Hit: 9 (2d6 + 2) piercing damage.",
                @"
Claws. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 7 (2d4 + 2) slashing damage. If the target is a creature
other than an elf or undead, it must succeed on a DC 10
Constitution saving throw or be paralyzed for 1 minute. The
target can repeat the saving throw at the end of each of its
turns, ending the effect on itself on a success."
                ];
        }
    }
}
