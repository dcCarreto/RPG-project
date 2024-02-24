namespace Creatures.BestiaryC1o4
{
    internal class GiantOwl : Creatures
    {
        readonly Dices dice = new();
        public GiantOwl()
        {
            Name = "Giant Owl";
            Type = ba;
            Size = l;
            Alignment = n;
            HitPoints = 19 + dice.RollMultiple(dice.d10, 3) + 3;
            ArmorClass = 12;
            Speed = "5ft, fly 60ft";
            Attributes = [13, 15, 12, 8, 13, 10];
            ChallengeLevel = "1/4";
            Experience = 50;
            Skills = "Perception +5, Stealth +4";
            Senses = "darkvision 120ft, passive Perception 15";
            Languages = "Giant Owl, understands Common, Elvish and Sylvan but can't speak them";
            Actions = [
                @"
Talons. Melee Weapon Attack: +3 to hit, reach 5 ft, one target.
Hit: 8 (2d6 + 1) slashing damage."
                ];
            Abilities = [
                @"
Flyby. The owl doesn't provoke opportunity attacks when it
flies out of an enemy's reach .",
                @"
Keen Hearing and Sight. The owl has advantage on Wisdom
(Perception) checks that rely on hearing or sight."
                ];
        }
    }
}
