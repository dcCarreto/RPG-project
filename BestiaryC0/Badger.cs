 

namespace Base.BestiaryC0
{
    internal class Badger : Creature
    {

        public Badger()
        {
            Name = "Badger";
            Type = Types.Beast;
            Size = Sizes.Tiny;
            Alignment = Alignments.Unaligned;
            HitPoints = 3 + Roll(4) + 1;
            Attributes = [4, 11, 12, 2, 12, 5];
            ArmorClass = 10;
            Speed = "20ft, burrow 5ft";
            Experience = 10;
            ChallengeLevel = "0";
            Senses = "darkvision 30ft, passive Perception";
            Actions = [
                @"
Bite. Melee Weapon Attack: +2 to hit, reach 5 ft., one target. Hit: 1 piercing damage."
                ];
            Abilities = [
                @"
Keen Smell. The badger has advantage on Wisdom (Perception) checks that rely on smell.",
                ];
            Attacks = new List<Attack>
            {
                new Attack (AttackList.Bite, DamageTypes.Piercing, RangeTypes.Melee, "1d2" )
            };

        }
    }
}
