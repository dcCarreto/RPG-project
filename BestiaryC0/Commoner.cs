using Creatures.Main;

namespace Creatures.BestiaryC0
{
    internal class Commoner : Creatures
    {
        readonly Dices dice = new();
        public Commoner()
        {
            Name = "Commoner";
            Type = hu;
            Size = m;
            Alignment = aa;
            HitPoints = 4 + dice.Roll(8);
            Attributes = [10, 10, 10, 10, 10, 10];
            ArmorClass = 10;
            Speed = "30ft";
            Experience = 10;
            ChallengeLevel = "0";
            Senses = "passive Perception 10";
            Languages = "any one language (usually Common)";
            Actions = [
                @"
Club. Melee Weapon Attack: +2 to hit, reach 5 ft, one target.
Hit: 2 (1d4), bludgeoning damage."
                ];
        }
    }
}
