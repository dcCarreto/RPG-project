namespace Creatures.BestiaryC1o4
{
    internal class Aarakocra : Creatures
    {
        readonly Dices dice = new();
        public Aarakocra()
        {
            Name = "Aarakocra";
            Type = hu;
            Size = m;
            Alignment = ng;
            HitPoints = 13 + (dice.Roll(dice.d8)) + (dice.Roll(dice.d8)) + (dice.Roll(dice.d8));
            Attributes = [10, 14, 10, 11, 12, 11];
            ArmorClass = 12;
            Speed = "20ft, fly 50ft";
            Experience = 50;
            ChallengeLevel = "1/4";
            Skills = "Perception +5";
            Senses = "passive Perception 15";
            Languages = "Auran";
            Actions = [
                @"
Dive Attack. If the aarakocra is flying and dives at least 30ft
straight toward a target and then hits it with a melee weapon
attack, the attack deals an extra 3 (1d6) damage to the target
",
                @"
Javelin. Melee or Ranged Weapon Attack: +4 to hit, reach 5ft, or
ranged 30/120ft, one target.
Hit: 5 (1d6 +2) piercing damage."
            ];
            Abilities = [
                @"
Talon. Melee Weapon Attack: +4 to hit, reach 5ft, one target.
Hit: 4 (1d4 + 2) slashing damage."
            ];
        }
    }
}
