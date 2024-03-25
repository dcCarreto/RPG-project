using Base;

namespace BestiaryIndex.BestiaryC0
{
    internal class CrawlingClaw : Creature
    {

        public CrawlingClaw()
        {
            Name = "Crawling Claw";
            Type = Types.Undead;
            Size = Sizes.Tiny;
            Alignment = Alignments.NeutralEvil;
            HitPoints = RollMultiple(4, 2);
            AttributeValue = [13, 14, 11, 5, 10, 4];
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
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Abilities = [
                @"
Turn Immunity: The claw is immune to effects that turn undead."
                ];
            Attacks = 
            [
                new (ActionList.Claws, DamageTypes.Slashing, RangeTypes.Melee, "1d4 + 1" ),
                new (ActionList.Claws, DamageTypes.Bludgeoning, RangeTypes.Melee, "1d4 + 1")
            ];
        }
    }
}
