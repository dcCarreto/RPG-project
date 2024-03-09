namespace Creatures.BestiaryC2
{
    internal class Nothic : Creature
    {
        public Nothic()
        {
            Name = "Nothic";
            Type = Types.Aberration;
            Size = Sizes.Medium;
            Alignment = Alignments.NeutralEvil;
            HitPoints = 45 + RollMultiple(8, 5) + 18;
            ArmorClass = 15;
            Speed = "30ft";
            Attributes = [14, 16, 16, 13, 10, 8];
            ChallengeLevel = "2";
            Experience = 450;
            Skills = "Arcana +3, Insight +4, Perception +2, Stealth +5";
            Senses = "truesight 120ft, passive Perception 12";
            Languages = "Undercommon";
            Actions = [
                @"
Multiattack. The nothic makes two c law attacks.",
@"
Claw. Melee Weapon Attack: +4 to hit, reach 5 ft., one t arget.
Hit: 6 (1d6 + 3) slashing damage.",
                @"
Rotting Gaze. The nothic t argets one creature it can see
within 30 feet of it. The target must succeed on a DC 12
Constitution saving throw against this magic or take 10 (3d6)
necrotic damage.",
                @"
Weird Insight. The nothic targets one creature it can see within
30 fe et of it. The target must contest its Charisma (Deception)
check against the nothic's Wisdom (In sight) check. If the
nothic wins, it magically learn s o ne fa ct o r secret about
the target. The target automatically wins if it is immune to
being charmed."
                ];
            Abilities = [
                @"
Keen Sight. The nothic has advantage on Wisdom (Pe rception)
checks that rely on s ight."
                ];
        }
    }
}
