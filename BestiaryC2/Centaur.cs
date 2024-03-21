namespace Base.BestiaryC2
{
    internal class Centaur : Creature
    {

        public Centaur()
        {
            Name = "Centaur";
            Type = Types.Monstruosity;
            Size = Sizes.Large;
            Alignment = Alignments.NeutralGood;
            HitPoints = 45 + RollMultiple(10, 6) + 12;
            ArmorClass = 12;
            Speed = "50ft";
            Attributes = [18, 14, 14, 9, 13, 11];
            ChallengeLevel = "2";
            Experience = 450;
            Skills = "Athletics +6, Perception +3, Survival +3";
            Senses = "passive Perception 13";
            Languages = "Elvish, Sylvan";
            Actions = [
                @"
Multiattack. The centaur makes two attacks: one with its pike
and one with its hooves or two with its longbow.",
                @"
Pike. Melee Weapon Attack: +6 to hit, reach 10ft., one target.
Hit: 9 (1d10 + 4) piercing damage.",
                @"
Hooves. Melee Weapon Attack: +6 to hit, reach 5 ft., one target.
Hit: 11 (2d6 + 4) bludgeoning damage.",
                @"
Longbow. Ranged Weapon Attack: +4 to hit, range 150/600 ft .,
one target. Hit: 6 (1d8 + 2) piercing damage."
                ];
            Abilities = [
                @"
Charge. If the centaur moves at least 30 feet straight toward a
target and then hits it with a pike attack on the same turn, the
target takes an extra 10 (3d6) piercing damage."
                ];
        }
    }
}
