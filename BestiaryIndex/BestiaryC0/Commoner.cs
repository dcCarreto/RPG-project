using Base;
namespace BestiaryIndex.BestiaryC0
{
    internal class Commoner : Creature
    {

        public Commoner()
        {
            Name = "Commoner";
            Type = Types.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.AnyAlignment;
            HitPoints = 4 + Roll(8);
            AttributeValue = [10, 10, 10, 10, 10, 10];
            ArmorClass = 10;
            Speed = "30ft";
            Experience = 10;
            ChallengeLevel = "0";
            Senses = "passive Perception 10";
            Languages = "any one language (usually Common)";
            Actions = [
                @"
Club. Melee Weapon Attack: +2 to hit, reach 5 ft, one target.
Hit: 2 (1d4), bludgeoning damage."
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Attacks = 
            [
                new (ActionList.Club, DamageTypes.Bludgeoning, RangeTypes.Melee, "2d4")
            ];

        }
    }
}
