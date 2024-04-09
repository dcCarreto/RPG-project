using Base;

namespace BestiaryIndex.BestiaryC3
{
    internal class BlueDragonWyrmling : Creature
    {
        public BlueDragonWyrmling()
        {
            Name = "Blue Dragon Wyrmling";
            Type = CreatureTypes.Dragon;
            Size = Sizes.Medium;
            Alignment = Alignments.LawfulEvil;
            HitPoints = 52 + RollMultiple(8, 8) + 16;
            ArmorClass = 17;
            Speed = "30ft, burrow 15ft, fly 60ft";
            AttributeValue = [17, 10, 15, 12, 11, 15];
            ChallengeLevel = "3";
            Experience = 700;
            SavingThrows = "Dexterity +2, Constitution +4, Wisdom +2, Charisma +4";
            DamageImmunities = "lightning";
            Skills = "Perception +4, Stealth +2";
            Senses = "blindsight 10ft, darkvision 60ft, passive Perception 14";
            Languages = "Draconic";
            Actions = [
                @"
Bite. Melee Weapon Attack: +5 to hit, reach 5 ft., one
target. Hit: 8 (1d10 + 3) piercing damage plus 3 (1d6)
lightning damage.",
                @"
Lightning Breath (Recharge 5-6}. The dragon exhales lightning
in a 30-foot line that is 5 feet wide. Each creature in that line
must make a DC 12 Dexterity saving throw, taking 22 (4d10)
lightning damage on a fai led save, or half as much damage on
a successful one."
                ];
        }
    }
}
