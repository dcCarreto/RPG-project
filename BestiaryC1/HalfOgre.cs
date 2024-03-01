namespace Creatures.BestiaryC1
{
    internal class HalfOgre : Creatures
    {

        public HalfOgre()
        {
            Name = "Half-Ogre";
            Type = gi;
            Size = l;
            Alignment = aca;
            HitPoints = 30 + RollMultiple(10, 4) + 8;
            ArmorClass = 12;
            Speed = "30ft";
            Attributes = [17, 10, 14, 7, 9, 10];
            ChallengeLevel = "1";
            Experience = 200;
            Senses = "darkvision 60ft, passive Perception 9";
            Languages = "Common, Giant";
            Actions = [
                @"
Battleaxe. Melee Weapon Attack: +5 to hit, reach 5 ft., one
target. Hit: 12 (2d8 + 3) slashing damage, or 14 (2d10 + 3)
slashing damage if used with two hands.",
@"
javelin. Melee or Ranged Weapon Attack: +5 to hit, reach 5 ft . or
range 30/120 ft., one target. Hit: 10 (2d6 + 3) piercing damage."
                ];
        }
    }
}
