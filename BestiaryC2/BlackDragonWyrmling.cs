namespace Creatures.BestiaryC2
{
    internal class BlackDragonWyrmling : Creature
    {

        public BlackDragonWyrmling()
        {
            Name = "Black Dragon Wyrmling";
            Type = Types.Dragon;
            Size = Sizes.Medium;
            Alignment = Alignments.ChaoticEvil;
            HitPoints = 33 + RollMultiple(8, 6) + 6;
            ArmorClass = 17;
            Speed = "30ft, fly 60ft, swim 30ft";
            Attributes = [15, 14, 13, 10, 11, 13];
            ChallengeLevel = "2";
            Experience = 450;
            SavingThrows = "Dexterity +4, Constitution +3, Wisdom +2, Charisma +3";
            DamageImmunities = "acid";
            Skills = "Perception +4, Stealth +4";
            Senses = "blindsight 10ft, darkvision 60ft, passive Perception 14";
            Languages = "Draconic";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 7 (1d10 + 2) piercing damage plus 2 (1d4) acid damage.",
                @"
Acid Breath (Recharge 5-6). The dragon exhales acid in a
15-foot line that is 5 feet wide. Each creature in that line
must make a DC 11 Dexterity saving throw, taking 22 (Sd8)
acid damage on a fa iled save, or half as much damage on a
successful one."
                ];
            Abilities = [
                @"
Amphibious. The dragon can breathe air and water."
                ];
        }
    }
}
