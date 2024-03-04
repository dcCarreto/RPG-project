namespace Creatures.BestiaryC2
{
    internal class GiantElk : CreatureAttributes
    {
        public GiantElk() 
        {
            Name = "Giant Elk";
            Type = ba;
            Size = h;
            Alignment = ud;
            HitPoints = 42 + RollMultiple(12, 5) + 10;
            ArmorClass = 14;
            Speed = "60ft";
            Attributes = [19, 16, 14, 7, 14, 10];
            ChallengeLevel = "2";
            Experience = 450;
            Skills = "Perception +4";
            Senses = "passive Perception 14";
            Languages = "Giant Elk, understands Common, Elvish and Sylvan but can`t speak them";
            Actions = [
                @"
Ram. Melee Weapon Attack: +6 to hit, reach 10ft., one target.
Hit: 11 (2d6 + 4) bludgeoning damage.",
                @"
Hooves. Melee Weapon Attack: +6 to hit, reach 5 ft ., one prone
creature. Hit: 22 (4d8 + 4) bludgeoning damage."
                ];
            Abilities = [
                @"
Charge. If the elk moves at least 20 feet straight toward a
target and then hits it with a ram attack on the same turn, the
target takes an extra 7 (2d6) damage. If the target is a creature,
it must succeed on a DC 14 Strength saving throw or be
knocked prone."
                ];
        }
    }
}
