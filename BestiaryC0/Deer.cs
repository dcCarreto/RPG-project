namespace Creatures.BestiaryC0

{
    internal class Deer : Creature
    {

        public Deer()
        {
            Name = "Deer";
            Type = ba;
            Size = m;
            Alignment = ud;
            HitPoints = 4 + Roll(8);
            Attributes = [11, 16, 11, 2, 14, 5];
            ArmorClass = 13;
            Speed = "50ft";
            Experience = 10;
            ChallengeLevel = "0";
            Senses = "passive Perception 12";
            Actions = [
                @"
Bite. Melee Weapon Attack: +2 to hit, reach 5 ft., one target.
Hit: 2 (1d4), piercing damage."
                ];
        }
    }
}


