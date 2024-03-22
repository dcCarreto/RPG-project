using Base;

namespace BestiaryIndex.BestiaryC3
{
    internal class Grell : Creature
    {
        public Grell()
        {
            Name = "Grell";
            Type = Types.Aberration;
            Size = Sizes.Medium;
            Alignment = Alignments.NeutralEvil;
            HitPoints = 55 + RollMultiple(8, 10) + 10;
            AttributeValue = [15, 14, 13, 12, 11, 9];
            ArmorClass = 12;
            Speed = "10ft, fly 30ft (hover)";
            Experience = 700;
            ChallengeLevel = "3";
            DamageImmunities = "lightning";
            ConditionImmunities = "blinded, prone";
            Skills = "Perception +4, Stealth +6";
            Senses = "blindsight 60ft (blind beyond this radius), passive Perception 14";
            Languages = "Grell";
            Actions = [
                @"
Multiattack. The grell makes two attacks: one with its tentacles and one with its beak",
                @"
Tentacles. Melee Weapon Attack: +4 to hit, reach 10ft, one creature.
Hit: 7 (1d10 + 2) piercing damage, and the target must succeed on a
DC 11 Constitution saving throw at the end of wach of its turns,
ending the effect on a success.
The target is also grappled (escape DC 15). If the target is
Medium or smaller, it is also re strained until this grapple ends.
While grappling the target, the grell has advantage on attack
rolls agai nst it and can 't use this attack aga inst other targets.
When the grell moves, any Medium or smaller target it is
grappling moves with it.",
                @"
Beak. Melee Weapon Attack: +4 to hit, reach 5ft, one creature.
Hit: 7 (2d4 + 2) piercing damage."
                ];
            HasMultiAttack = true;
            Attacks = 
            [
                new (AttackList.Tentacles, DamageTypes.Piercing, RangeTypes.Melee, "1d10 + 2"),
                new (AttackList.Beak, DamageTypes.Piercing, RangeTypes.Melee, "2d4 + 2")
            ];
        }
    }
}
