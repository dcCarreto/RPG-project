namespace Creatures.BestiaryC1o4
{
    internal class Goblin : Creatures
    {
        readonly Dices dice = new();
        public Goblin()
        {
            Name = "Goblin";
            Type = hu;
            Size = s;
            Alignment = ne;
            HitPoints = 7 + dice.RollMultiple(dice.d6, 2);
            Attributes = [8, 14, 10, 10, 8, 8];
            ArmorClass = 15;
            Speed = "30ft";
            Experience = 50;
            ChallengeLevel = "1/4";
            Skills = "Stealth +4";
            Senses = "darkvision 60ft, passive Perception 9";
            Languages = "Common, Goblin";
            Actions = [
                @"
Scimitar. Melee Weapon Attack: +4 to hit, reach 5ft, one target",
                @"
Shortbow. Ranged Weapon Attack: +4 to hit, range 80/320ft, one target.
Hit: 5 (1d6 + 2) piercing damage."
                ];
            Abilities = [
                @"
Nimble Escape. The goblin can take the Disengage or Hide action as a
bonus action on each of its turns."
                ];
        }
    }
}
