using Base;

namespace BestiaryIndex.BestiaryC1o4
{
    internal class Pteranodon : Creature
    {

        public Pteranodon()
        {
            Name = "Pteranodon";
            Type = CreatureTypes.Beast;
            Size = Sizes.Medium;
            Alignment = Alignments.Unaligned;
            HitPoints = 13 + RollMultiple(8, 3);
            AttributeValue = [12, 15, 10, 2, 1, -3];
            ArmorClass = 13;
            Speed = "10ft., fly 60ft.";
            Experience = 50;
            ChallengeLevel = "1/4";
            Skills = "Perception +1";
            Senses = "passive Perception 11";
            Actions = [
                @"
Bite. Melee Weapon Attack: +3 to hit, reach 5ft., one target.
Hit: 6 (2d4 + 1) piercing damage."
            ];
            Abilities = [
                @"
Flyby. The pteranodon doesn't provoke an opportunity attack
when it flies out of an enemy's reach.

"
            ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Attacks =
                [
                new(ActionList.Bite, DamageTypes.Piercing, RangeTypes.Melee, "2d4 + 1")
                ];

        }
    }
}
