namespace Creatures.BestiaryC2
{
    internal class GiantBoar : Creatures
    {
        public GiantBoar()
        {
            Name = "Giant Boar";
            Type = ba;
            Size = l;
            Alignment = ud;
            HitPoints = 42 + RollMultiple(10, 5) + 15;
            ArmorClass = 12;
            Speed = "40ft";
            Attributes = [17, 10, 16, 2, 7, 5];
            ChallengeLevel = "2";
            Experience = 450;
            Senses = "passive Perception 8";
            Actions = [
                @"
Tusk. Melee Weapon Attack: +5 to hit, reach 5 ft ., one target.
Hit: 10 (2d6 + 3) slashing damage."
                ];
            Abilities = [
                @"
Charge. If the boar moves at least 20 feet straight toward a
target and then hits it with a tusk attack on the same turn, the
target takes an extra 7 (2d6) slashing damage. If the target is a
creature, it must succeed on a DC 13 Strength saving throw or
be knocked prone.",
                @"
Relentless (Recharges after a Short or Long Rest). If the boar
takes 10 damage or less that would reduce it to 0 hit points, it
is reduced to 1 hit point instead."
                ];
        }
    }
}
