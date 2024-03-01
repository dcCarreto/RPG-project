namespace Creatures.BestiaryC1o4
{
    internal class AxeBeak : Creatures
    {

        public AxeBeak()
        {
            Name = "Axe Beak";
            Type = ba;
            Size = l;
            Alignment = ud;
            HitPoints = 19 + RollMultiple(10, 3) + 3;
            ArmorClass = 11;
            Speed = "50ft";
            Attributes = [14, 12, 12, 2, 10, 5];
            ChallengeLevel = "1/4";
            Experience = 50;
            Senses = "passive PErception 10";
            Actions = [
                @"
Beak. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 6 (1d8 + 2) slashing damage."
                ];
        }
    }
}
