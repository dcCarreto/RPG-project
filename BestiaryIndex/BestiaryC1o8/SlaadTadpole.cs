using Base;

namespace BestiaryIndex.BestiaryC1o8
{
    internal class SlaadTadpole : Creature
    {

        public SlaadTadpole()
        {
            Name = "Slaad Tadpole";
            Type = CreatureTypes.Aberration;
            Size = Sizes.Tiny;
            Alignment = Alignments.ChaoticNeutral;
            HitPoints = 10 + RollMultiple(4, 4);
            AttributeValue = [7, 15, 10, 3, 5, 3];
            ArmorClass = 12;
            Speed = "30ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            DamageResistances = "acid, cold, fire, lighting, thunder";
            Skills = "Stealth +4";
            Senses = "darkvision 60ft, passive Perception 7";
            Languages = "understands Slaad but can't speak";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5ft, one target.
Hit: 4 (1d4 + 2) piercing damage."
                ];

            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Abilities = [
                @"                
                Magic Resistance. The Slaad had advantage on saving throws"
            ];
            Attacks =
                [
                new(ActionList.Bite, DamageTypes.Piercing, RangeTypes.Melee, "1d4 + 2")
                ];
        }
    }
}