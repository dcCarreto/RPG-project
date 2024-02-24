namespace Creatures.BestiaryC1o4
{
    internal class Acolyte : Creatures
    {
        readonly Dices dice = new();
        public Acolyte()
        {
            Name = "Acolyte";
            Type = hu;
            Size = m;
            Alignment = aa;
            HitPoints = 9 + dice.RollMultiple(dice.d8, 2);
            ArmorClass = 10;
            Speed = "30ft";
            Attributes = [10, 10, 10, 10, 14, 11];
            ChallengeLevel = "1/4";
            Experience = 50;
            Skills = "Medicine +4, Religion +2";
            Senses = "passive Perception 10";
            Languages = "any one language (usually Common)";
            Actions = [
                @"
Club. Melee Weapon Attack: +2 to hit, reach 5 ft, one target.
Hit: 2 (1d4) bludgeoning damage."
                ];
            Abilities = [
                @"
Spellcasting. The acolyte is a 1st-level spellcaster.
Its spellcasting ability is Wisdom (spell save DC 12, +4 to hit with
spell attacks).

The acolyte has following cleric spells prepared:
Cantrips (at will) : light, sacred flame, thaumaturgy
1st level (3 slots): bless, cure wounds, sanctuary"
                ];
        }
    }
}
