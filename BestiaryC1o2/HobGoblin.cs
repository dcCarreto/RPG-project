namespace Creatures.BestiaryC1o2
{
    internal class HobGoblin : Creature
    {

        public HobGoblin()
        {
            Name = "Hobgoblin";
            Type = Types.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.LawfulEvil;
            HitPoints = 11 + RollMultiple(8, 2) + 2;
            ArmorClass = 18;
            Speed = "30ft";
            Attributes = [13, 12, 12, 10, 10, 9];
            ChallengeLevel = "1/2";
            Experience = 100;
            Senses = "darkvision 60ft, passive Perception 10";
            Languages = "Common, Goblin";
            Actions = [
                @"
Longsword. Melee Weapon Attack: +3 to hit, reach 5 ft., one
target. Hit: 5 (1d8 + 1) slashing damage, or 6 (1d10 + 1)
s lashing damage if used with two hands.",
                @"
Longbow. Ranged Weapon Attack: +3 to hit, range 150/600 ft.,
one target. Hit: 5 (1d8 + 1) piercing damage."
                ];
            Abilities = [
                @"
Martial Advantage. Once per turn, the hobgobl in can deal an
extra 7 (2d6) damage to a creatu re it hits with a weapon attack
if that creature is within 5 feet of an ally of the hobgoblin that
isn't incapacitated."
                ];
        }
    }
}
