using Base;

namespace BestiaryIndex.BestiaryC1o4
{
    internal class Troglodyte : Creature
    {

        public Troglodyte()
        {
            Name = "Troglodyte";
            Type = Types.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.ChaoticEvil;
            HitPoints = 13 + RollMultiple(8, 2) + 4;
            ArmorClass = 11;
            Speed = "30ft";
            AttributeValue = [14, 10, 14, 6, 10, 6];
            ChallengeLevel = "1/4";
            Experience = 50;
            Skills = "Stealth +2";
            Senses = "darkvision 60ft, passive Perception 10";
            Languages = "Troglodyte";
            Actions = [
                @"
Multiattack. The troglodyte makes three attacks: one with its
bite and two with its claws.",
@"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft, one target.
Hit: 4 (1d4 + 2) piercing damage.",
@"
Claw. Melee Weapon Attack: +4 to hit, reach 5 ft, one target.
Hit: 4 (1d4 + 2) slashing damage."
                ];
            Abilities = [
                @"
Chameleon Skin. The troglodyte has advantage on Dexterity
(Stealth) checks made to hide.",
@"
Stench. Any creature other than a troglodyte that starts its
turn within 5 ft of the troglodyte must succeed on a DC 12
Constitution saving throw or be poisoned until the start of the
creature's next turn. On a successful saving throw, the creature
is immune to the stench of all troglodytes for 1 hour.",
@"
Sunlight Sensitivity. While in sunlight, the troglodyte
has disadvantage on attack rolls, as well as on Wisdom
(Perception) checks that rely on sight."
                ];

        }
    }
}
