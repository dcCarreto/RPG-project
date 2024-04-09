using Base;
namespace BestiaryIndex.BestiaryC1
{
    internal class GiantHyena : Creature
    {

        public GiantHyena()
        {
            Name = "Giant Hyena";
            Type = CreatureTypes.Beast;
            Size = Sizes.Large;
            Alignment = Alignments.Unaligned;
            HitPoints = 45 + RollMultiple(10, 6) + 12;
            ArmorClass = 12;
            Speed = "50ft";
            AttributeValue = [16, 14, 14, 2, 12, 7];
            Skills = "Perception +3";
            Senses = "passive Perception 13";
            Actions = [
                @"
Bite. Melee Weapon Attack: +5 to hit, reach 5 ft., one target.
Hit: 10 (2d6 + 3) piercing damage."
                ];
            Abilities = [
                @"
Rampage. When the hyena reduces a creature to 0 hit points
with a melee attack on its turn, the hyena can take a bonus
action to move up to half its speed and make a bite attack."
                ];
        }
    }
}
