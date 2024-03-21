namespace Base.BestiaryC1o2
{
    internal class IceMephit : Creature
    {

        public IceMephit()
        {
            Name = "Ice Mephit";
            Type = Types.Elemental;
            Size = Sizes.Small;
            Alignment = Alignments.NeutralEvil;
            HitPoints = 21 + RollMultiple(6, 6);
            ArmorClass = 11;
            Speed = "30ft, fly 30ft";
            Attributes = [7, 13, 10, 9, 11, 12];
            ChallengeLevel = "1/2";
            Experience = 100;
            DamageVulnerabilities = "bludgeoning, fire";
            DamageImmunities = "cold, poison";
            ConditionImmunities = "poisoned";
            Skills = "Perception +2, Stealth +3";
            Senses = "darkvision 60ft, passive Perception 12";
            Languages = "Aquan, Auran";
            Actions = [
                @"
Claws. Melee Weapon Attack: +3 to hit, reach 5 ft., one creature.
Hit: 3 (1d4 + 1) slashing damage plus 2 (ld4) cold damage.",
                @"
Frost Breath (Recharge 6). The mephit exhales a 15-foot cone
of cold air. Each creature in that area must succeed on a DC 10
Dexterity saving throw, taking 5 (2d4) cold damage on a failed
save, or half as much damage on a successful one."
                ];
            Abilities = [
                @"
Death Burst. When the mephit dies, it explodes in a burst of
jagged ice. Each creature within 5 feet of it must make a DC 10
Dexterity saving throw, taking 4 (1d8) slashing damage on a
failed save, or half as much damage on a successful one.",
                @"
False Appearance. While the mephit remains motionless, it is
indistinguishable from an ordinary shard of ice.",
                @"
Innate Spellcasting (1jDay). The mephit can innately cast
fog cloud, requiring no material components. Its innate
spellcasting ability is Charisma."
                ];
        }
    }
}
