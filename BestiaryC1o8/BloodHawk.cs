namespace Creatures.BestiaryC1o8
{
    internal class BloodHawk : Creature
    {

        public BloodHawk()
        {
            Name = "Blood Hawk";
            Type = ba;
            Size = s;
            Alignment = ud;
            HitPoints = 7 + RollMultiple(6, 2);
            Attributes = [6, 14, 10, 3, 14, 5];
            ArmorClass = 12;
            Speed = "60ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Skills = "Perception +4";
            Senses = "passive Perception 14";
            Actions = [
                @"
Beak. Melee Weapon Attack: +4 to hit, reach 5ft, one target.
Hit: 4 (1d4 + 2) piercing damage."
                ];
            Abilities = [
                @"                
Pack tactics. The hawk had advantage on an attack roll against
a creature if at least one of the hawk`s allies is within 5ft
of the creature and the ally isn`t incapacitated.",
                @"
Keen Sight. The hawk had advantage on Wisdom (Perception)
checks that rely on sight."
            ];
            Attacks = new List<Attack>
            {
                new Attack {AtkName = AttackList.Beak, Types = DamageTypes.Piercing, Range = RangeTypes.Melee, Dice = "1d4 + 2" }
            };
        }
    }
}