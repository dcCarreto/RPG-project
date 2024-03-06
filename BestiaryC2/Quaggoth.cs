namespace Creatures.BestiaryC2
{
    internal class Quaggoth : Creature
    {
        public Quaggoth() 
        {
            Name = "Quaggoth";
            Type = hu;
            Size = m;
            Alignment = cn;
            HitPoints = 45 + RollMultiple(8, 6) + 18;
            ArmorClass = 13;
            Speed = "30ft, climb 30ft";
            Attributes = [17, 12, 16, 6, 12, 7];
            ChallengeLevel = "2";
            Experience = 450;
            DamageImmunities = "poison";
            ConditionImmunities = "poisoned";
            Skills = "Athletics + 5";
            Senses = "darkvision 120ft, passive Perception 10";
            Languages = "Undercommon";
            Actions = [
                @"
Multiattack. The quaggoth makes two claw attacks.",
@"
Claw. Melee Weapon Attack: +5 to hit, reach 5 ft., one target.
Hit: 6 (ld6 + 3) slashing damage."
                ];
            Abilities = [
                @"
Wounded Fury. While it has 10 hit points or fewer, the
quaggoth has advantage on attack rolls. In addition, it deals an
extra 7 (2d6) damage to any target it hits with a melee attack."
                ];
        }
    }
}
