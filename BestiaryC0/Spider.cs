using Creatures.CombatAttributes;

namespace Creatures.BestiaryC0
{
    internal class Spider : Creature
    {

        public Spider()
        {
            Name = "Spider";
            Type = Types.Beast;
            Size = Sizes.Tiny;
            Alignment = Alignments.Unaligned;
            HitPoints = 1 + Roll(4) - 1;
            Attributes = [2, 14, 8, 1, 10, 2];
            ArmorClass = 12;
            Speed = "20ft, climb 20ft";
            Experience = 10;
            ChallengeLevel = "0";
            Skills = "Stealth +4";
            Senses = "Darkvision 30ft, passive Perception 10";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft., one creature.
Hit: 1 piercing damage, and the target must succeed on a DC 9 Constitution saving throw or take 2 (1d4) poison damage."];
            Abilities = [
                @"
Spider Climb. The spider can climb difficult surfaces, including upside down on ceilings,
without needing to make an ability check.",
                @"
Web Sense. While in contact with a web, the spider knows the exact location of any
other creature in contact with the same web.",
                @"
Web Walker. The spider ignores movement restrictions caused by webbing."
            ];
            Attacks = new List<Attack>
            {
                new Attack ( AttackList.Bite, DamageTypes.Piercing, RangeTypes.Melee, "1d4")
            };
        }
    }
}