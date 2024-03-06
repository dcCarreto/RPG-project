namespace Creatures.BestiaryC1o4
{
    internal class GiantCentipede : Creature
    {

        public GiantCentipede()
        {
            Name = "Giant Centipede";
            Type = ba;
            Size = s;
            Alignment = ud;
            HitPoints = 4 + Roll(6) + 1;
            ArmorClass = 13;
            Speed = "30ft, climb 30ft";
            Attributes = [5, 14, 12, 1, 7, 3];
            ChallengeLevel = "1/4";
            Experience = 50;
            Senses = "blindsight 30ft, passive Perception 8";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft, one creature.
Hit: 4 (ld4 + 2) piercing damage, and the target must succeed
on a DC 11 Constitution saving throw or take 10 (3d6) poison
damage. If the poison damage reduces the target to 0 hit
points, the target is stable but poisoned for 1 hour, even
after regaining hit points, and is paralyzed while poisoned
in this way."
                ];
        }
    }
}
