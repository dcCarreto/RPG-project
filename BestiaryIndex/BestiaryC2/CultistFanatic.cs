using Base;

namespace BestiaryIndex.BestiaryC2
{
    internal class CultistFanatic : Creature
    {
        public CultistFanatic()
        {
            Name = "Cultist Fanatic";
            Type = CreatureTypes.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.AnyNonGoodAlignment;
            HitPoints = 33 + RollMultiple(8, 6) + 6;
            ArmorClass = 13;
            Speed = "30ft";
            AttributeValue = [11, 14, 12, 10, 13, 14];
            ChallengeLevel = "2";
            Experience = 450;
            Skills = "Deception +4, Persuasion +4, Religion +2";
            Senses = "passive Perception 10";
            Languages = "any one language (usually Common)";
            Actions = [
                @"
Multiattack. The fan atic makes two melee attacks.",
                @"
Dagger. Melee or Ranged Weapon Attack: +4 to
hit, reach 5 ft. or range 20/60 ft., one creature.
Hit: 4 (1d4 + 2) piercing damage."
                ];
            Abilities = [
                @"
Dark Devotion. The fanatic has advantage on saving throws
against being charmed or fri ghtened.",
                @"
Spellcasting. The fanatic is a 4th-level spellcaster. Its
spell casting ability is Wisdom (spell save DC 11, +3 to hit
with spell attacks). The fanatic has the following cleric
spells prepared:
Cantrips (at will) : light, sacred flam e, thaumaturgy
1st level (4 slots): command, inflict wounds, shield of faith
2nd level (3 slots): hold person, spiritual weapon"
                ];
        }
    }
}
