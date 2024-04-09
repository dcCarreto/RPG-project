using Base;
namespace BestiaryIndex.BestiaryC1
{
    internal class Hippogriff : Creature
    {

        public Hippogriff()
        {
            Name = "Hippogriff";
            Type = CreatureTypes.Monstruosity;
            Size = Sizes.Large;
            Alignment = Alignments.Unaligned;
            HitPoints = 19 + RollMultiple(10, 3) + 3;
            ArmorClass = 11;
            Speed = "40ft, fly 60ft";
            AttributeValue = [17, 13, 13, 2, 12, 8];
            ChallengeLevel = "1";
            Experience = 200;
            Skills = "Perception +5";
            Senses = "passive Perception 15";
            Actions = [
                @"
Multiattack. The hippogriff makes two attacks: one with its
beak and one with its claws.",
                @"
Beak. Melee Weapon Attack: +5 to hit, reach 5 ft., one target.
Hit: 8 (1d10 + 3) piercing damage.",
                @"
Claws. Melee Weapon Attack: +5 to hit , reach 5 ft., one target.
Hit: 10 (2d6 + 3) slashing damage."
                ];
            Abilities = [
                @"
Keen Sight. The hippogriffhas advantage on Wisdom
(Perception) checks that rely on s ight."
                ];
        }
    }
}
