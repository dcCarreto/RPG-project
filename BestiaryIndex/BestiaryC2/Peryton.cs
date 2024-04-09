using Base;

namespace BestiaryIndex.BestiaryC2
{
    internal class Peryton : Creature
    {
        public Peryton()
        {
            Name = "Peryton";
            Type = CreatureTypes.Monstruosity;
            Size = Sizes.Medium;
            Alignment = Alignments.ChaoticEvil;
            HitPoints = 33 + RollMultiple(8, 6) + 6;
            ArmorClass = 13;
            Speed = "20ft, fly 60ft";
            AttributeValue = [16, 12, 13, 9, 12, 10];
            ChallengeLevel = "2";
            Experience = 450;
            DamageResistances = "bludgeoning, piercing and slashing from nonmagical weapons";
            Skills = "Perception +5";
            Senses = "passive Perception 15";
            Languages = "understands Common and Elvish but can`t speak";
            Actions = [
                @"
Multiattack. The peryton makes one gore attack and one
talon attack.",
                @"
Gore. Melee Weapon Attack: +5 to hit, reach 5 ft ., one target.
Hit: 7 (1d8 + 3) piercing damage.",
                @"
Talons. Melee Weapon Attack: +5 to hi t, reach 5 ft., one target.
Hit: 8 (2d4 + 3) piercing damage."
                ];
            Abilities = [
                @"
Dive Attack. If the peryton is flying and dives at least 30 feet
straight toward a target and then hits it with a melee weapon
attack, the attack deals an extra 9 (2d8) damage to the target.",
@"
Flyby. The peryton doesn't provoke an opportunity attack when
it flies out of an enemy's reach.",
@"
Keen Sight and Smell. The peryton has advantage on Wisdom
(Perception) checks that rely on sight or smell ."
                ];

        }
    }
}
