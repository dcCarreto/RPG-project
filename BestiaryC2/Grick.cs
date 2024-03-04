namespace Creatures.BestiaryC2
{
    internal class Grick : CreatureAttributes
    {

        public Grick()
        {
            Name = "Grick";
            Type = mo;
            Size = m;
            Alignment = n;
            HitPoints = 27 + RollMultiple(8, 6);
            ArmorClass = 14;
            Speed = "30ft, cimb 30ft";
            Attributes = [14, 14, 11, 3, 14, 5];
            ChallengeLevel = "2";
            Experience = 450;
            DamageResistances = "bludgeoning, piercing and slashing from nonmagical weapons";
            Senses = "darkvision 60ft, passive Perception 12";
            Actions = [
                @"
Multiattack. The grick makes one attack with its tentacles. If
that attack hits, the grick can make one beak attack against the
same target.",
                @"
Tentacles. Melee Weapon Attack: +4 to hit, reach 5 ft. , one
target. Hit: 9 (2d6 + 2) slashing damage.",
                @"
Beak. Melee Weapon Attack: +4 to hit, reach 5 ft ., one target.
Hit: 5 (1d6 + 2) piercing damage."
                ];
            Abilities = [
                @"
Stone Camouflage. The grick has advantage on Dexterity
(Stealth) checks made to hide in rocky terra in."
                ];
        }
    }
}
