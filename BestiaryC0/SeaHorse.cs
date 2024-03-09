namespace Creatures.BestiaryC0
{
    internal class SeaHorse : Creature
    {

        public SeaHorse()
        {
            Name = "Sea Horse";
            Type = ba;
            Size = t;
            Alignment = ud;
            HitPoints = 1 + Roll(4) - 1;
            Attributes = [1, 12, 8, 1, 10, 2];
            ArmorClass = 11;
            Speed = "0ft, swim 20ft";
            Experience = 0;
            ChallengeLevel = "0";
            Senses = "passive Perception 10";
            Abilities = [
                @"
Water Breathing. The sea horse can breathe only underwater."
            ];
            Attacks = new List<Attack>
            {
                new Attack {AtkName = AttackList.Ram, Types = DamageTypes.Bludgeoning, Range = RangeTypes.Melee, Dice = "1d1" }
            };
        }
    }
}