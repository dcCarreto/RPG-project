namespace Creatures.BestiaryC0
{
    internal class Crab : Creature
    {

        public Crab()
        {
            Name = "Crab";
            Type = ba;
            Size = t;
            Alignment = ud;
            HitPoints = 2 + Roll(4);
            Attributes = [2, 11, 10, 1, 8, 2];
            ArmorClass = 11;
            Speed = "20ft, swim 20ft";
            Experience = 10;
            ChallengeLevel = "0";
            Skills = "Stealth +2";
            Senses = "blindsight 30ft, passive Perception 9";
            Actions = [
                @"
Claw. Melee Weapon Attack: +0 to hit, reach 5 ft, one target.
Hit: 1 bludgeoning damage."
                ];
            Abilities = [
                @"
Amphibious. The crab can breathe air and water."
                ];
            Attacks = new List<Attack>
            {
                new Attack {AtkName = AttackList.Claws, Types = DamageTypes.Bludgeoning, Range = RangeTypes.Melee, Dice = "1d2" }
            };
        }
    }
}
