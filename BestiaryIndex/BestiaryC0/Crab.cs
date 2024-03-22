using Base;
namespace BestiaryIndex.BestiaryC0
{
    internal class Crab : Creature
    {

        public Crab()
        {
            Name = "Crab";
            Type = Types.Beast;
            Size = Sizes.Tiny;
            Alignment = Alignments.Unaligned;
            HitPoints = 2 + Roll(4);
            AttributeValue = [2, 11, 10, 1, 8, 2];
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
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Abilities = [
                @"
Amphibious. The crab can breathe air and water."
                ];
            Attacks = 
            [
                new (AttackList.Claws, DamageTypes.Bludgeoning, RangeTypes.Melee, "1d2" )
            ];
        }
    }
}
