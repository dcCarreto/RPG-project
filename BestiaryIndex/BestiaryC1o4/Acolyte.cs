using Base;

namespace BestiaryIndex.BestiaryC1o4
{
    internal class Acolyte : Creature
    {

        public Acolyte()
        {
            Name = "Acolyte";
            Type = Types.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.AnyAlignment;
            HitPoints = 9 + RollMultiple(8, 2);
            ArmorClass = 10;
            Speed = "30ft";
            AttributeValue = [10, 10, 10, 10, 14, 11];
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
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Attacks =
                [
                new(ActionList.Club, DamageTypes.Bludgeoning, RangeTypes.Melee, "1d4")
                ];
        }
    }
}
