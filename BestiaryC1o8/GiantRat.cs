namespace Creatures.BestiaryC1o8
{
    internal class GiantRat : Creature
    {

        public GiantRat()
        {
            Name = "Giant Rat";
            Type = ba;
            Size = s;
            Alignment = ud;
            HitPoints = 7 + RollMultiple(6, 2);
            Attributes = [7, 15, 11, 2, 10, 4];
            ArmorClass = 12;
            Speed = "30ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Senses = "darkvision 60ft, passive Perception 10";
            Actions = [
                @"
 Bite. Melee Weapon Attack: +4 to hit, reach 5ft, one target.
 Hit: 4 (1d4 + 2) piercing damage."
                ];
            Abilities = [
                @"               
Keen Smell. The rat has advantage on Wisdon ( Perception )
checks that rely on smell.",
                @"
Pack Tactics. The rat had advantage on an attack roll against
a creature if at least on of the rat`s allies is within 5ft
of the creature and the ally isn`t incapacitated."
            ];
        }
    }
}