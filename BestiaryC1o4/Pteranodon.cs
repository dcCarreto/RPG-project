namespace Creatures.BestiaryC1o4
{
    internal class Pteranodon : Creatures
    {
        readonly Dices dice = new();
        public Pteranodon()
        {
            Name = "Pteranodon";
            Type = ba;
            Size = m;
            Alignment = ud;
            HitPoints = 13 + dice.RollMultiple(dice.d8, 3);
            Attributes = [12, 15, 10, 2, 1, -3];
            ArmorClass = 13;
            Speed = "10ft., fly 60ft.";
            Experience = 50;
            ChallengeLevel = "1/4";
            Skills = "Perception +1";
            Senses = "passive Perception 11";
            Actions = [
                @"
Bite. Melee Weapon Attack: +3 to hit, reach 5ft., one target.
Hit: 6 (2d4 + 1) piercing damage."
            ];
            Abilities = [
                @"
Flyby. The pteranodon doesn't provoke an opportunity attack
when it flies out of an enemy's reach.

"
            ];
            
        }
    }
}
