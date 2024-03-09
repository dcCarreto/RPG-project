namespace Creatures.BestiaryC0
{
    internal class CrawlingClaw : Creature
    {

        public CrawlingClaw()
        {
            Name = "Crawling Claw";
            Type = un;
            Size = t;
            Alignment = ne;
            HitPoints = RollMultiple(4, 2);
            Attributes = [13, 14, 11, 5, 10, 4];
            ArmorClass = 12;
            Speed = "20ft, climb 20ft";
            Experience = 10;
            ChallengeLevel = "0";
            DamageImmunities = "poison";
            ConditionImmunities = "charmed, exhaustion, poisoned";
            Senses = "blindsight 30ft (blind beyond this radius), passive Perception 10";
            Languages = "understands Common but can't speak";
            Actions = [
                @"
Claw. Melee Weapon Attack: +3 to hit, reach 5 ft, one target.
Hit: 3 (1d4 + 1), bludgeoning or slashing damage (claw's choice)"
                ];
            Abilities = [
                @"
Turn Immunity: The claw is immune to effects that turn undead."
                ];
            Attacks = new List<Attack>
            {
                new Attack {AtkName = AttackList.Claws, Types = DamageTypes.Slashing, Range = RangeTypes.Melee, Dice = "1d4 + 1" },
                new Attack {AtkName = AttackList.Claws, Types = DamageTypes.Bludgeoning, Range = RangeTypes.Melee, Dice = "1d4 + 1" }
            };
        }
    }
}
