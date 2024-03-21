 

namespace Base.BestiaryC0
{
    internal class Hyena : Creature
    {

        public Hyena()
        {
            Name = "Hyena";
            Type = Types.Beast;
            Size = Sizes.Medium;
            Alignment = Alignments.Unaligned;
            HitPoints = 5 + Roll(8) + 1;
            Attributes = [11, 13, 12, 2, 12, 5];
            ArmorClass = 11;
            Speed = "50ft";
            Experience = 10;
            ChallengeLevel = "0";
            Skills = "Perception +3";
            Senses = "passive Perception 13";
            Actions = [
                @"
Bite. Melee Weapon Attack: +2 to hit, reach 5 ft., one target. Hit: 3 (1d6) piercing damage."
            ];
            Abilities = [
                @"
Pack Tactics. The hyena has advantage on an attack roll against a creature if at least one
of the hyena's allies is within 5 feet of the creature and the ally isn't incapacitated."
            ];
            Attacks = new List<Attack>
            {
                new Attack ( AttackList.Bite, DamageTypes.Piercing, RangeTypes.Melee, "1d6")
            };
        }
    }
}