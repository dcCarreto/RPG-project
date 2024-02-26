namespace Creatures.BestiaryC1o2
{
    internal class Worg : Creatures
    {
        readonly Dices dice = new();
        public Worg()
        {
            Name = "Worg";
            Type = mo;
            Size = l;
            Alignment = ne;
            HitPoints = 26 + dice.RollMultiple(dice.d10, 4) + 4;
            ArmorClass = 13;
            Speed = "50ft";
            Attributes = [16, 13, 13, 7, 11, 8];
            ChallengeLevel = "1/2";
            Experience = 100;
            Skills = "Perception +4";
            Senses = "darkvision 60ft, passive Perception 14";
            Languages = "Goblin, Worg";
            Actions = [
                @"
Bite. Melee Weapon Attack: +5 to hit, reach 5 ft ., one target.
Hit: 10 (2d6 + 3) piercing damage. If the target is a creature,
it must succeed on a DC 13 Strength saving throw or be
knocked prone."
                ];
            Abilities = [
                @"
Keen Hearing and Smell. The worg has advantage on Wisdom
(Perception) checks that rely on hearing or smell."
                ];
        }
    }
}
