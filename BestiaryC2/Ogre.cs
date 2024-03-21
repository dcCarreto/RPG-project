namespace Base.BestiaryC2
{
    internal class Ogre : Creature
    {
        public Ogre()
        {
            Name = "Ogre";
            Type = Types.Giant;
            Size = Sizes.Large;
            Alignment = Alignments.ChaoticEvil;
            HitPoints = 59 + RollMultiple(10, 7) + 21;
            ArmorClass = 11;
            Speed = "40ft";
            Attributes = [19, 8, 16, 5, 7, 7];
            ChallengeLevel = "2";
            Experience = 450;
            Senses = "darkvision 60ft, passive Perception 8";
            Languages = "Common, Giant";
            Actions = [
                @"
Greatclub. Melee Weapon Attack: +6 to hit, reach 5 ft., one
target. Hit: 13 (2d8 + 4) bludgeoning damage.",
@"
javelin. Melee or Ranged Weapon Attack: +6 to hit, reach 5 ft. or
range 30/120 ft., one target. Hit: 11 (2d6 + 4) piercing damage."
                ];

        }
    }
}
