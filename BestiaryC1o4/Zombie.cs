namespace Creatures.BestiaryC1o4
{
    internal class Zombie : Creatures
    {
        readonly Dices dice = new();
        public Zombie()
        {
            Name = "Zombie";
            Type = un;
            Size = m;
            Alignment = ne;
            HitPoints = 22 + dice.RollMultiple(dice.d8, 3) + 9;
            ArmorClass = 8;
            Speed = "20ft";
            Attributes = [13, 6, 16, 3, 6, 5];
            ChallengeLevel = "1/4";
            Experience = 50;
            SavingThrows = "Wisdom +0";
            DamageImmunities = "poison";
            ConditionImmunities = "poisoned";
            Senses = "understands the languages it knew in life but can't speak";
            Actions = [
                @"
Slam. Melee Weapon Attack: +3 to hit, reach 5 ft., one target.
Hit: 4 (1d6 + 1) bludgeoning damage."
                ];
            Abilities = [
                @"
Undead Fortitude. If damage reduces the zombie to 0 hit
points, it must make a Constitution saving throw with a DC
of 5 the damage taken, unless the damage is radiant or
from a critical hit. On a success, the zombie drops to 1 hit
point in stead."
                ];
        }
    }
}
