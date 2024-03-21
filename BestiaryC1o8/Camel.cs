 

namespace Base.BestiaryC1o8
{
    internal class Camel : Creature
    {

        public Camel()
        {
            Name = "Camel";
            Type = Types.Beast;
            Size = Sizes.Large;
            Alignment = Alignments.Unaligned;
            HitPoints = 15 + (Roll(10) + Roll(10)) + 4;
            Attributes = [16, 8, 14, 2, 8, 5];
            ArmorClass = 9;
            Speed = "50ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Senses = "passive Perception 9";
            Actions = [
                @"
Bite. Melee Weapon Attack: +5 to hit, reach 5ft, one target.
Hit. 2 (1d4) bludgeoning damage."
            ];
            Attacks = new List<Attack>
            {
                new Attack ( AttackList.Bite, DamageTypes.Bludgeoning, RangeTypes.Melee, "1d4")
            };
        }
    }
}