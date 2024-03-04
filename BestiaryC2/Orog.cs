namespace Creatures.BestiaryC2
{
    internal class Orog : CreatureAttributes
    {
        public Orog() 
        {
            Name = "Orog";
            Type = hu;
            Size = m;
            Alignment = ce;
            HitPoints = 42 + RollMultiple(8, 5) + 20;
            ArmorClass = 18;
            Speed = "30ft";
            Attributes = [18, 12, 18, 12, 11, 12];
            ChallengeLevel = "2";
            Experience = 450;
            Skills = "Intimidation +5, Survival +2";
            Senses = "darkvision 60ft, passive Perception 10";
            Languages = "Common, Orc";
            Actions = [
                @"
Multiattack. The orog makes two greataxe attacks.",
                @"
Greataxe. Melee Weapon Attack: +6 to hit, reach 5 ft., one
target. Hit: 10 (1d12 + 4) slashing damage.",
                @"
javelin. Melee or Ranged Weapon Attack: +6 to hit, reach 5 ft. or
range 30/120 ft ., one target. Hit: 7 (1d6 + 4) piercing damage."
                ];
            Abilities = [
                @"
Aggressive. As a bonus action, the orog can move up to its
speed toward a hostile creature that it can see."
                ];
        }
    }
}
