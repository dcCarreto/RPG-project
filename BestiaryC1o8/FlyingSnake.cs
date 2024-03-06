namespace Creatures.BestiaryC1o8
{
    internal class FlyingSnake : Creature
    {

        public FlyingSnake()
        {
            Name = "Flying Snake";
            Type = ba;
            Size = t;
            Alignment = ud;
            HitPoints = 5 + RollMultiple(4, 2);
            Attributes = [4, 18, 11, 2, 12, 5];
            ArmorClass = 14;
            Speed = "30ft, fly 60ft, swim 30ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Senses = "blindsight 10ft, passive Perception 11";
            Actions = [
                @"
Bite. Melee Weapon Attack: +6 to hit, reach 5ft, one target.
Hit: 1 piercing damage 7 (3d4) poison damage."
                ];
            Abilities = [
                @"                
Flyby. the snake doesn`t provoke opportunity attacks when it
flies out of an enemy`s reach."
            ];
        }
    }
}