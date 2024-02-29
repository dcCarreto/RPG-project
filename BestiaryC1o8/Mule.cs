using Creatures.Main;

namespace Creatures.BestiaryC1o8
{
    internal class Mule : Creatures
    {
        readonly Dices dice = new();
        public Mule()
        {
            Name = "Mule";
            Type = ba;
            Size = m;
            Alignment = ud;
            HitPoints = 11 + dice.RollMultiple(8, 2) + 2;
            Attributes = [14, 10, 13, 2, 10, 5];
            ArmorClass = 10;
            Speed = "40ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Senses = "passive Perception 10";
            Actions = [
                @"
 Hooves. Melee Weapon Attack: +2 to hit, reach 5ft, one target.
Hit: 4 (1d4 + 2) bludgeoning damage."
                ];
            Abilities = [
                @"               
Beast of Burden. The mule is considered to be a Large animal
for the purpose of determining its carrying capacity.",
                @"
Sure-Footed. The mule had advantage on Strength and Dexterity
saving throws made against effects that would knock it prone."
            ];
        }
    }
}