namespace Creatures.BestiaryC2
{
    internal class OrcEyeOfGruumsh : CreatureAttributes
    {
        public OrcEyeOfGruumsh()
        {
            Name = "Orc Eye of Gruumash";
            Type = hu;
            Size = m;
            Alignment = ce;
            HitPoints = 45 + RollMultiple(8, 6) + 18;
            ArmorClass = 16;
            Speed = "30ft";
            Attributes = [16, 12, 16, 9, 13, 12];
            ChallengeLevel = "2";
            Experience = 450;
            Skills = "Intimidation +3, Religion +1";
            Senses = "darkvision 60ft, passive Perception 11";
            Languages = "Common, Orc";
            Actions = [
                @"
Spear. Melee or Ranged Weapon Attack: +5 to hit, reach 5 ft. or
range 20/60 ft., one target. Hit: 11 (ld6 + 3 plus ld8) piercing
damage, or 12 (2d8 + 3) piercing damage if used with two
hands to make a melee attack."
                ];
            Abilities = [
                @"
Aggressive. As a bonus action, the ore can move up to its speed
toward a hostile creature that it can see.",
                @"
Gruumsh's Fury. The ore deals an extra 4 (ld8) damage when it
hits with a weapon attack (included in the attack).",
                @"
Spellcasting. The ore is a 3rd-level spellcaster. Its spellcasting
ability is Wisdom (spell save DC 11, +3 to hit with spell attacks).
The ore has the following cleric spells prepared:
Cantrips (at-will): guidance, resistance, thaumaturgy
1st level (4 slots): bless, command
2nd level (2 slots): augury, spiritual weapon (spear)"
                ];
        }
    }
}
