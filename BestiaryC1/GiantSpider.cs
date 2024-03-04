namespace Creatures.BestiaryC1
{
    internal class GiantSpider : CreatureAttributes
    {

        public GiantSpider()
        {
            Name = "Giant Spider";
            Type = ba;
            Size = l;
            Alignment = ud;
            HitPoints = 26 + RollMultiple(10, 4) + 4;
            ArmorClass = 14;
            Speed = "30ft, climb 30ft";
            Attributes = [14, 16, 12, 2, 11, 4];
            ChallengeLevel = "1";
            Experience = 200;
            Skills = "Stealth +7";
            Senses = "blindsight 10ft, darkvision 60ft, passive Perception 10";
            Actions = [
                @"
Bite. Melee Weapon Attack: +5 to hit, reach 5 ft., one creature.
Hit: 7 (1d8 + 3) piercing damage, and the target must make a
DC 11 Constitution saving throw, taking 9 (2d8) poison damage
on a failed save, or half as much damage on a successful one.
If the poison damage reduces the target to 0 hit points, the
target is stable but poisoned for 1 hour, even after regaining hit
points, and is paralyzed while poisoned in this way.",
                @"
Web (Recharge 5-6}. Ranged Weapon Attack: +5 to hit,
range 30f60 ft., one creature. Hit: The target is restrained by
webbing. As an action, the restrained target can make a DC
12 Strength check, bursting the webbing on a success. The
webbing can also be attacked and destroyed (AC 10; hp 5;
vulnerability to fire damage; immunity to bludgeoning, poison,
and psychic damage)."
                ];
            Abilities = [
                @"
Spider Climb. The spider can climb difficult surfaces, including
upside down on ceilings, without needing to make an
ability check.",
                @"
Web Sense. While in contact with a web, the spider knows the
exact location of any other creature in contact with the same web.",
                @"
Web Walker. The spider ignores movement restrictions caused
by webbing."
                ];
        }
    }
}
