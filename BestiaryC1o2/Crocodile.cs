using Creatures.Main;

namespace Creatures.BestiaryC1o2
{
    internal class Crocodile : Creatures
    {
        readonly Dices dice = new();
        public Crocodile()
        {
            Name = "Crocodile";
            Type = ba;
            Size = l;
            Alignment = ud;
            HitPoints = 19 + dice.RollMultiple(10, 3) + 3;
            ArmorClass = 12;
            Speed = "20ft, swim 30ft";
            Attributes = [15, 10, 13, 2, 10, 5];
            ChallengeLevel = "1/2";
            Experience = 100;
            Skills = "Stealth +2";
            Senses = "passive Perception 10";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft., one
creature. Hit: 7 (1d10 + 2) piercing damage, and the target is
grappled (escape DC 12). Until this grapple ends, the target is
restrained, and the crocodile can't bite another target."
                ];
            Abilities = [
                @"
Hold Breath. The crocodile can hold its breath for 15 minutes."
                ];
        }
    }
}
