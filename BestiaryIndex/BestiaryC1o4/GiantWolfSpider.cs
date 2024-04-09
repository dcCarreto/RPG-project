using Base;

namespace BestiaryIndex.BestiaryC1o4
{
    internal class GiantWolfSpider : Creature
    {

        public GiantWolfSpider()
        {
            Name = "Giant Wolf Spider";
            Type = CreatureTypes.Beast;
            Size = Sizes.Medium;
            Alignment = Alignments.Unaligned;
            HitPoints = 11 + RollMultiple(8, 2) + 2;
            ArmorClass = 13;
            Speed = "40ft, climb 40ft";
            AttributeValue = [12, 16, 13, 3, 12, 4];
            ChallengeLevel = "1/4";
            Experience = 50;
            Skills = "Perception +3, Stealth +7";
            Senses = "blindsight 10ft, darkvision 60ft, passive Perception 13";
            Actions = [
                @"
Bite. Melee Weapon Attack: +3 to hit, reach 5 ft, one creature.
Hit: 4 (1d6 + 1) piercing damage, and the target must make a
DC 11 Constitution saving throw, taking 7 (2d6) poison damage
on a failed save, or half as much damage on a successful one.
If the poison damage reduces the target to 0 hit points, the
target is stable but poisoned for 1 hour, even after regaining hit
points, and is paralyzed while poisoned in this way."
                ];
            Abilities = [
                @"
Spider Climb. The spider can climb difficult surfaces, including
upside down on ceilings, without needing to make an
ability check.",
                @"
Web Sense. While in contact with a web, the spider knows
the exact location of any other creature in contact with
the same web.",
                @"
Web Walker. The spider ignores movement restrictions caused
by webbing."
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = true;
            Attacks =
                [
                new(ActionList.Bite, DamageTypes.Piercing, RangeTypes.Melee, "1d6 + 1", 7, 5, DamageTypes.Poison, "2d6", 11, AttributeName.Constitution)
                ];
        }
    }
}
