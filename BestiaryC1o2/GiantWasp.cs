namespace Creatures.BestiaryC1o2
{
    internal class GiantWasp : Creatures
    {
        readonly Dices dice = new();
        public GiantWasp()
        {
            Name = "Giant Wasp";
            Type = ba;
            Size = m;
            Alignment = ud;
            HitPoints = 13 + dice.RollMultiple(dice.d8, 3);
            ArmorClass = 12;
            Speed = "10ft, fly 50ft";
            Attributes = [10, 14, 10, 1, 10, 3];
            ChallengeLevel = "1/2";
            Experience = 100;
            Senses = "passive Perception 10";
            Actions = [
                @"
Sting. Melee Weapon Attack: +4 to hit, reach 5 ft., one creature.
Hit: 5 (1d6 + 2) piercing damage, and the target must make
a DC 11 Constitution saving throw, taking 10 (3d6) poison
damage on a failed save, or half as much damage on a
successful one. If the poison damage reduces the target to 0
hit points, the target is stable but poisoned for 1 hour, even
after regaining hit points, and is paralyzed while poisoned
in this way."
                ];
        }
    }
}
