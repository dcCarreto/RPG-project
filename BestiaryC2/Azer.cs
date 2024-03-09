namespace Creatures.BestiaryC2
{
    internal class Azer : Creature
    {

        public Azer()
        {
            Name = "Azer";
            Type = Types.Elemental;
            Size = Sizes.Medium;
            Alignment = Alignments.LawfulNeutral;
            HitPoints = 39 + RollMultiple(8, 6) + 12;
            ArmorClass = 17;
            Speed = "30ft";
            Attributes = [17, 12, 15, 12, 13, 10];
            ChallengeLevel = "2";
            Experience = 450;
            SavingThrows = "Constitution +4";
            DamageImmunities = "fire, poison";
            ConditionImmunities = "poisoned";
            Senses = "passive Perception 11";
            Languages = "Ignan";
            Actions = [
                @"
Warhammer. Melee Weapon Attack: +5 to hit, reach 5 ft ., one
target. Hit: 7 (1d8 + 3) bludgeoning damage, or 8 (1d10 + 3)
bludgeoning damage if used with two hands to make a melee
attack, plus 3 (1d6) fire damage."
                ];
            Abilities = [
                @"
Heated Body. A creature that touches the azer or hits it with a
melee attack while within 5 feet of it takes 5 (1d10) fire damage.",
@"
Heated Weapons. When the azer hits with a metal melee
weapon, it deals an extra 3 (1d6) fire damage (included in
the attack).",
@"
Illumination. The azer sheds bright light in a 10-foot radius and
dim light for an additional10 feet."
                ];
        }
    }
}
