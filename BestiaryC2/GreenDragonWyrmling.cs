namespace Creatures.BestiaryC2
{
    internal class GreenDragonWyrmling : Creature
    {

        public GreenDragonWyrmling()
        {
            Name = "Green Dragon Wyrmling";
            Type = Types.Dragon;
            Size = Sizes.Medium;
            Alignment = Alignments.LawfulEvil;
            HitPoints = 38 + RollMultiple(8, 7) + 7;
            ArmorClass = 17;
            Speed = "30ft, fly 60ft, swim 30ft";
            Attributes = [15, 12, 13, 14, 11, 13];
            ChallengeLevel = "2";
            Experience = 450;
            Languages = "Draconic";
            SavingThrows = "Dexterity +3, Constitution +3, Wisdom +2, Charisma +3";
            DamageImmunities = "poison";
            ConditionImmunities = "poisoned";
            Skills = "Perception +4, Stealth +3";
            Senses = "blindsight 10ft, darkvision 60ft, passive Perception 14";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 7 (1d10 + 2) piercing damage plus 3 (1d6) poison damage.",
                @"
Poison Breath (Recharge 5-6). The dragon exhales poisonous
gas in a 15-foot cone. Each creature in that area must make
a DC 11 Constitution saving throw, taking 21 (6d6) poison
damage on a failed save, or half as much damage on a
successful one."
                ];
            Abilities = [
                @"
Amphibious. The dragon can breathe air and water."
                ];
        }
    }
}
