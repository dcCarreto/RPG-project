namespace Base.BestiaryC1o2
{
    internal class Gnoll : Creature
    {

        public Gnoll()
        {
            Name = "Gnoll";
            Type = Types.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.ChaoticEvil;
            HitPoints = 22 + RollMultiple(8, 5);
            ArmorClass = 15;
            Speed = "30ft";
            Attributes = [14, 12, 11, 6, 10, 7];
            ChallengeLevel = "1/2";
            Experience = 100;
            Senses = "darkvision 60ft, passive Perception 10";
            Languages = "Gnoll";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft, one creature.
Hit: 4 (1d4 + 2) piercing damage.",
                @"
Spear. Melee or Ranged Weapon Attack: +4 to hit, reach 5 ft or
range 20J60 ft, one target.
Hit: 5 (1d6 + 2) piercing damage, or 6 (1d8 + 2) piercing damage
if used with two hands to make a melee attack.",
                @"
Longbow. Ranged Weapon Attack: +3 to hit, range 150/600 ft, one target.
Hit: 5 (1d8 + 1) piercing damage."
                ];
            Abilities = [
                @"
Rampage. When the gnoll reduces a creature to 0 hit points
with a melee attack on its turn, the gnoll can take a bonus
action to move up to half its speed and make a bite attack."
                ];
        }
    }
}
