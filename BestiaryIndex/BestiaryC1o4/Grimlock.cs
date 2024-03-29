using Base;

namespace BestiaryIndex.BestiaryC1o4
{
    internal class Grimlock : Creature
    {

        public Grimlock()
        {
            Name = "Grimlock";
            Type = Types.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.NeutralEvil;
            HitPoints = 11 + RollMultiple(8, 2) + 2;
            AttributeValue = [16, 12, 12, 9, 8, 6];
            ArmorClass = 11;
            Speed = "30ft";
            Experience = 50;
            ChallengeLevel = "1/4";
            ConditionImmunities = "blinded";
            Skills = "Athletic +5, Perception +3, Stealth +3";
            Senses = "blindsight 30ft or 10ft while deafened (blind beyond this radius), passive Perception 13";
            Languages = "Undercommon";
            Actions = [
                @"
Spiked Bone Club. Melee Weapon Attack: +5 to hit, reach 5f, one target.
Hit: 5 (1d4 + 3) bludgeoning damage plus 2 (1d4) piercing damage."];
            Abilities = [
                @"
Blind Senses. The grimlock can't use its blindsight while deafened
and unable to smell.",
                @"
Keen Hearing and Smell. The grimlock has advantage on Wisdom
(Perception) checks that rely on hearing or smell.",
                @"
Stone Camouflage. The grimlock had advantage on Dexterity
(Stealth) checks made to hide in rocky terrain"
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Attacks =
                [
                new(ActionList.SpikedBoneClub, DamageTypes.Bludgeoning, RangeTypes.Melee, "2d4 + 3")
                ];
        }
    }
}
