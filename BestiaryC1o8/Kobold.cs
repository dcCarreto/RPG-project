namespace Creatures.BestiaryC1o8
{
    internal class Kobold : Creatures
    {
        readonly Dices dice = new ();
        public Kobold()
        {
            Name = "Kobold";
            Type = hu;
            Size = s;
            Alignment = le;
            HitPoints = 5 + dice.RollMultiple(dice.d6, 2) - 2;
            Attributes = [7,15, 9, 8, 7, 8];
            ArmorClass = 12;
            Speed = "30ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Senses = "darksvision 60ft, passive Perception 8";
            Languages = "Common, Draconic";
            Actions = [
                @"
Dagger. Melee Weapon Attack: +4 tp hit, reach 5ft, one target.
Hit: 4 (1d4 + 2) piercing damage.",
                @"
Sling. Ranged Weapon Attack: +4 to hit, range 30/120ft, onde target.
Hit: 4 (1d4 + 2) bludgeoning damage."
            ];
            Abilities = [
                @"
                Sunlight Sensivity. While in sunlight, the Kobold has disadvantage
                on attack rolls, as well as on Wisdom(Perception) checks that rely
                on sight.",
                @"
                Pack Tactics. The Kobold had advantage on an attack roll against a
                creature if at least one of the Kobold`s allies is within 5 feet
                of the creature and the ally isn`t incapacitated."         
            ];

        }
    }
}