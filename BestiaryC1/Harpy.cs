namespace Creatures.BestiaryC1
{
    internal class Harpy : Creatures
    {

        public Harpy()
        {
            Name = "Harpy";
            Type = mo;
            Size = m;
            Alignment = ce;
            HitPoints = 38 + RollMultiple(8, 7) + 7;
            ArmorClass = 11;
            Speed = "20ft, fly 40ft";
            Attributes = [12, 13, 12, 7, 10, 13];
            ChallengeLevel = "1";
            Experience = 200;
            Senses = "passive Perception 10";
            Languages = "Common";
            Actions = [
                @"
Multiattack. The harpy makes two attacks: one with its claws
and one with its club.",
                @"
Claws. Melee Weapon Attack: +3 to hit, reach 5 ft., one target.
Hit: 6 (2d4 + 1) slashing damage.",
                @"
Club. Melee Weapon Attack: +3 to hit, reach 5 ft., one target.
Hit: 3 (1d4 + 1) bludgeoning damage.",
                @"
Luring Song. The harpy sings a magical melody. Every
humanoid and giant within 300 feet of the harpy that can hear
the song must succeed on a DC 11 Wisdom saving throw or
be charmed until the song ends. The harpy must take a bonus
action on its subsequent turns to continue singing. It can stop
singing at any time. The song ends if the harpy is incapacitated.
While charmed by the harpy, a target is incapacitated and
ignores the songs of other harpies. If the charmed target is
more than 5 feet away from the harpy, the target can take
the Dash action on its turn to move toward the harpy by the
most direct route. It doesn't avoid opportunity attacks, but
before moving into damaging terrain, such as lava or a pit, and
whenever it takes damage from a source other than the harpy,
a target can repeat the saving throw. A creature can also repeat
the saving throw at the end of each of its turns. If a creature's
saving throw is successful, the effect ends on it.
A target that successfully saves is immune to this harpy's
song for the next 24 hours."
                ];
        }
    }
}
