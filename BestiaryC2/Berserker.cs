namespace Creatures.BestiaryC2
{
    internal class Berserker : CreatureAttributes
    {
        public Berserker()
        {
            Name = "Berserker";
            Type = hu;
            Size = l;
            Alignment = aca;
            HitPoints = 67 + RollMultiple(8, 9) + 27;
            ArmorClass = 13;
            Speed = "30ft";
            Attributes = [16, 12, 17, 9, 11, 9];
            ChallengeLevel = "2";
            Experience = 450;
            Senses = "darkvision 60ft, passive Perception 9";
            Languages = "any one language (usually Common)";
            Actions = [
                @"
Greataxe. Melee Weapon Attack: +5 to hit, reach 5 ft. , one
target. Hit: 9 (1d12 + 3) slash ing damage.",
                ];
            Abilities = [
                @"
Reckless. At the start of its turn, the berserker can gain
advantage on all melee weapon attack ro lls during that turn,
but attack rolls against it have advantage until the start of
its next turn."
                ];
        }
    }
}
