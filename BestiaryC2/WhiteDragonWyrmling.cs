namespace Creatures.BestiaryC2
{
    internal class WhiteDragonWyrmling : CreatureAttributes
    {

        public WhiteDragonWyrmling()
        {
            Name = "White Dragon Wyrmling";
            Type = dr;
            Size = m;
            Alignment = ce;
            HitPoints = 32 + RollMultiple(8, 5) + 10;
            ArmorClass = 16;
            Speed = "30ft, burrow 15ft, fly 60ft, swim 30ft";
            Attributes = [14, 10, 14, 5, 10, 11];
            ChallengeLevel = "2";
            Experience = 450;
            SavingThrows = "Dexterity +2, Constitution +4, Wisdom +2, Charisma +2";
            DamageImmunities = "cold";
            Skills = "Perception +4, Stealth +2";
            Senses = "blindsight 10ft, darkvision 60ft, passive Perception 14";
            Languages = "Draconic";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 7 (1d10 + 2) piercing damage plus 2 (1d4) cold damage.",
                @"
Cold Breath (Recharge 5-6). The dragon exha les an icy blast of
hail in a 15-foot cone. Each creature in that area must make a
DC 12 Constitution saving throw, taking 22 (5d8) cold damage
on a failed save, or half as much damage on a successful one."
                ];
        }
    }
}
