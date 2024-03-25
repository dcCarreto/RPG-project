using Base;

namespace BestiaryIndex.BestiaryC1o4
{
    internal class GiantBadger : Creature
    {

        public GiantBadger()
        {
            Name = "Giant Badger";
            Type = Types.Beast;
            Size = Sizes.Medium;
            Alignment = Alignments.Unaligned;
            HitPoints = 13 + RollMultiple(8, 2) + 4;
            ArmorClass = 10;
            Speed = "30ft, burrow 10ft";
            AttributeValue = [13, 10, 15, 2, 12, 5];
            ChallengeLevel = "1/4";
            Experience = 50;
            Senses = "darkvision 30ft, passive Perception 11";
            Actions = [
                @"
Multiattack. The badger makes two attacks: one with its bite
and one with its claws.",
                @"
Bite. Melee Weapon Attack: +3 to hit, reach 5 ft., one target.
Hit: 4 (1d6 + 1) piercing damage.",
                @"
Claws. Melee Weapon Attack: +3 to hit, reach 5 ft., one target.
Hit: 6 (2d4 + 1) slashing damage."
                ];
            Abilities = [
                @"
Keen Smell. The badger has advantage on Wisdom (Perception)
checks that rely on smell."
                ];
            HasMultiAttack = true;
            HasSaveOnAttack = false;
            Attacks =
                [
                new(ActionList.Bite, DamageTypes.Piercing, RangeTypes.Melee, "1d6 + 1"),
                new(ActionList.Claws, DamageTypes.Slashing, RangeTypes.Melee, "2d4 + 1")
                ];
        }
    }
}
