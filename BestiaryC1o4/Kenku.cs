namespace Base.BestiaryC1o4
{
    internal class Kenku : Creature
    {

        public Kenku()
        {
            Name = "Kenku";
            Type = Types.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.ChaoticNeutral;
            HitPoints = 13 + RollMultiple(8, 3);
            Attributes = [10, 16, 10, 11, 10, 10];
            ArmorClass = 13;
            Speed = "30ft";
            Experience = 50;
            ChallengeLevel = "1/4";
            Skills = "Deception +4, Perception +2, Stealth +5";
            Senses = "passive Perception 12";
            Languages = "Understands Auran and Common but speaks only through the use of Mimicry trait";
            Actions = [
                @"
Shortword. Melee Weapon Attack: +5 to hit, reach 5ft, one target.
Hit: 6 (1d6 +3) piercing damage.",
                @"
Shortbow. Ranged Weapon Attack: +5 to hit, range 80/320ft, one target.
Hit: 6 (1d6 +3) piercing damage."
                ];
            Abilities = [
                @"
Ambusher. The kenku has advatage on attack rolls against any creature
it has surprised.",
                @"
Mimicry. The kenku can mimic any sounds it has heard, including voices.
A creature that hears the sound can tell they are imitations with a 
successful DC 14 Wisdom (Insight) check."
                ];
        }
    }
}
