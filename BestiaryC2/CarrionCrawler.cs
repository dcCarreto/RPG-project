namespace Creatures.BestiaryC2
{
    internal class CarrionCrawler : CreatureAttributes
    {

        public CarrionCrawler()
        {
            Name = "Carrion Crawler";
            Type = mo;
            Size = l;
            Alignment = ud;
            HitPoints = 51 + RollMultiple(10, 6) + 18;
            ArmorClass = 13;
            Speed = "30ft, climb 30ft";
            Attributes = [14, 13, 16, 1, 12, 5];
            ChallengeLevel = "2";
            Experience = 450;
            Skills = "Perception +3";
            Senses = "darkvision 60ft, passive Perception 13";
            Actions = [
                @"
Multiattack. The carrion crawler makes two attacks: one with
its tentacles and one with its bite.",
                @"
Tentacles. Melee Weapon Attack: +8 to hit, reach 10ft., one
creature. Hit: 4 (1 4 + 2) poison damage, and the target must
succeed on a DC 13 Constitution saving throw or be poisoned
for 1 minute. Until this poison ends, the ta rget is paralyzed.
The target can repeat the saving throw at the end of each of its
tu rns, ending the poison on itself on a success.",
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft ., one target.
Hit: 7 (2d4 + 2) piercing damage."
                ];
            Abilities = [
                @"
Keen Smell. The carrion crawler has advantage on Wisdom
(Perception) checks that rely on smell.",
                @"
Spider Climb. The carrion crawler can cl imb difficult surfaces,
including upside down on ceilings, without needing to make an
ability check."
                ];
        }
    }
}
