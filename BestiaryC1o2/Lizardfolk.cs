namespace Creatures.BestiaryC1o2
{
    internal class Lizardfolk : CreatureAttributes
    {

        public Lizardfolk()
        {
            Name = "Lizardfolk";
            Type = hu;
            Size = m;
            Alignment = n;
            HitPoints = 22 + RollMultiple(8, 4) + 4;
            ArmorClass = 15;
            Speed = "30ft, swim 30ft";
            Attributes = [15, 10, 13, 7, 12, 7];
            ChallengeLevel = "1/2";
            Experience = 100;
            Skills = "Perception +3, Stealth +4, Survival +5";
            Senses = "passive Perception 13";
            Languages = "Draconic";
            Actions = [
                @"
Multiattack. The lizardfolk makes two melee attacks, each one
with a diffe rent weapon.",
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 5 (1d6 + 2) piercing damage.",
                @"
Heavy Club. Melee Weapon Attack: +4 to hit, reach 5 ft., one
target. Hit: 5 (1d6 + 2) bludgeoning damage.",
                @"
javelin. Melee or Ranged Weapon Attack: +4 to hit, reach 5 ft. or
range 30/ 120 ft ., one target. Hit: 5 (1d6 + 2) piercing damage.",
                @"
Spiked Shield. Melee Weapon Attack: +4 to hit, reach 5 ft., one
target. Hit: 5 (1d6 + 2) piercing damage."
                ];
            Abilities = [
                @"
Hold Breath. The lizardfolk can hold its breath for 15 minutes."
                ];
        }
    }
}
