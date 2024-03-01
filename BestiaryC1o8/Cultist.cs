namespace Creatures.BestiaryC1o8
{
    internal class Cultist : Creatures
    {

        public Cultist()
        {
            Name = "Cultist";
            Type = hu;
            Size = m;
            Alignment = ana;
            HitPoints = 9 + RollMultiple(8, 2);
            Attributes = [11, 12, 10, 10, 11, 10];
            ArmorClass = 12;
            Speed = "30ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Skills = "Deception +2, Religion +2";
            Senses = "passive Perception 10";
            Languages = "any one language (usually common)";
            Actions = [
                @"
Scimitar. Melee Weapon Attack: +3 to hit, reach 5ft, one target.
Hit: 4 (1d6 +1) slashing damage.",
                @"
Light Crossbow. Ranged Weapon Attack: +3 to hit, range 80/320ft,
one Target. Hit: 5 (1d8 + 1) piercing damage."
                ];
            Abilities = [
                @"
Dark Devotion. The cultist had advantage on savin throws
against being charmed or fightened"
            ];
        }
    }
}