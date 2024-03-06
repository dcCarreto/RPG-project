namespace Creatures.BestiaryC2
{
    internal class BronzeDragonWyrmling : Creature
    {

        public BronzeDragonWyrmling()
        {
            Name = "Bronze Dragon Wyrmling";
            Type = dr;
            Size = m;
            Alignment = lg;
            HitPoints = 32 + RollMultiple(8, 5) + 10;
            ArmorClass = 17;
            Speed = "30ft, fly 60ft, swim 30ft";
            Attributes = [17, 10, 15, 12, 11, 15];
            ChallengeLevel = "2";
            Experience = 450;
            SavingThrows = "Dexterity +2, Constitution +4, Charisma +4";
            DamageImmunities = "lightning";
            Skills = "Perception +4, Stealth +2";
            Senses = "blindsight 10ft, darkvision 60ft, passive Perception 14";
            Languages = "Draconic";
            Actions = [
                @"
Bite. Melee Weapon Attack: +5 to hit, reach 5 ft. , one target.
Hit: 8 (1d10 + 3) piercing damage.",
                @"
Breath Weapons (Recharge 5-6). The dragon uses one of the
following breath weapons.",
                @"
Lightning Breath. The dragon exhales lightning in a 40-foot line
that is 5 feet wide. Each creature in that line must make a DC
12 Dexterity saving throw, taking 16 (3d10) lightning damage
on a failed save, or half as much damage on a successful one.",
                @"
Repulsion Breath. The dragon exhales repulsion energy in a
30-foot cone. Each creature in that area must succeed on a
DC 12 Strength saving throw. On a failed save, the creature is
pushed 30 feet away from the dragon."
                ];
            Abilities = [
                @"
Amphibious. The dragon can breathe air and water."
                ];
        }
    }
}
