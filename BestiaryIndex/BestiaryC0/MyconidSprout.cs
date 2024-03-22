using Base;
namespace BestiaryIndex.BestiaryC0
{
    internal class MyconidSprout : Creature
    {

        public MyconidSprout()
        {
            Name = "Myconid Sprout";
            Type = Types.Plant;
            Size = Sizes.Small;
            Alignment = Alignments.LawfulNeutral;
            HitPoints = 7 + RollMultiple(6, 2);
            AttributeValue = [8, 10, 10, 8, 11, 5];
            ArmorClass = 10;
            Speed = "10ft";
            Experience = 10;
            ChallengeLevel = "0";
            Senses = "darkvision 120ft, passive Perception 10";
            Actions = [
                @"
Fist. Melee Weapon Attack:+ 1 to hit, reach 5 ft, one target.
Hit:1 (1d4- 1), bludgeoning damage plus 2 (1d4), poison damage.",
                @"
Rapport Spores (3jDay). A 10-foot radius of spores extends from the myconid.
These spores can go around corners and affect only creatures with an Intelligence
of 2 or higher that aren't undead, constructs, or elementals.
Affected creatures can communicate telepathically with one another while they
are within 30 feet of each other. The effect lasts for 1 hour."
            ];
            hasMultiAttack = false;
            hasSaveOnAttack = false;
            Abilities = [
                @"
Distress Spores: When the myconid takes damage, all other myconids
within 240 feet of it can sense its pain.",
                @"
Sun Sickness: While in sunlight, the myconid has disadvantage on
ability checks, attack rolls, and saving throws.
The myconiddies if it spends more than 1 hour in direct sunlight."
            ];
            Attacks = 
            [
                new ( AttackList.Fist, DamageTypes.Bludgeoning, RangeTypes.Melee, "1d4 - 1")
            ];
        }
    }
}

