namespace Creatures.BestiaryC1o4
{
    internal class WingedKobold : Creature
    {

        public WingedKobold()
        {
            Name = "Winged Kobold";
            Type = Types.Humanoid;
            Size = Sizes.Small;
            Alignment = Alignments.LawfulEvil;
            HitPoints = 7 + RollMultiple(6, 3) - 3;
            Attributes = [7, 16, 9, 8, 7, 8];
            ArmorClass = 13;
            Speed = "30ft, fly 30ft";
            Experience = 50;
            ChallengeLevel = "1/4";
            Senses = "darkvision 60ft, passive Perception 8";
            Languages = "Common, Draconic";
            Actions = [
                @"
Dagger. Melee Weapon Attack: +5 to hit, reach 5ft, one target.
Hit: 5 (1d4 + 3) piercing damage",
                @"
Dropped Rock. Ranged Weapon Attack: +5 to hit, one target directly below the kobold.
Hit: 6 (1d6 +3) bludgeoning damage."
                ];
            Abilities = [
                @"
Sunlight Sensivity. While in the sunlight, the kobold has disavantage on attack rolls,
as well as on Wisdom (Perception) checks that rely on sight.",
                @"
Pack Tactics. The kobold has advantage on an attack roll agains a creature if at least
one of the kobold's allies is within 5ft of the creature and the ally isn't incapacitated."
                ];
        }
    }
}
