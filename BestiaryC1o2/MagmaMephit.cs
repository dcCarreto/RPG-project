namespace Creatures.BestiaryC1o2
{
    internal class MagmaMephit : CreatureAttributes
    {

        public MagmaMephit()
        {
            Name = "Magma Mephit";
            Type = el;
            Size = s;
            Alignment = ne;
            HitPoints = 22 + RollMultiple(6, 5) + 5;
            ArmorClass = 11;
            Speed = "30ft, fly 30ft";
            Attributes = [8, 12, 12, 7, 10, 10];
            ChallengeLevel = "1/2";
            Experience = 100;
            DamageVulnerabilities = "cold";
            DamageImmunities = "fire, poison";
            ConditionImmunities = "posioned";
            Skills = "Stealth +3";
            Senses = "darkvision 60ft, passive Perception 10";
            Languages = "Ignan, Terran";
            Actions = [
                @"
Claws. Melee Weapon Attack: +3 to hit, reach 5 ft ., one creature.
Hit: 3 (1d4 + 1) slashing damage plus 2 (1d4) fire damage.",
@"
Fire Breath (Recharge 6). The mephit exhales a 15-foot cone
of fire. Each creature in that area must make a DC 11 Dexterity
saving throw, taking 7 (2d6) fire damage on a failed save, or
half as much damage on a successful one."
                ];
            Abilities = [
                @"
Death Burst. When the mephit dies, it explodes in a burst
of lava. Each creature within 5 feet of it must make a DC 11
Dexterity saving throw, taking 7 (2d6) fire damage on a failed
save, or half as much damage on a successful one.",
                @"
False Appearance. While the mephit remains motionless, it is
indistinguishable from an ordinary mound of magma.",
                @"
Innate Spellcasting (1JDay). The mephit can innately cast heat
metal (spell save DC 10), requiring no material components.
Its innate spellcasting ability is Charisma."
                ];
        }
    }
}
