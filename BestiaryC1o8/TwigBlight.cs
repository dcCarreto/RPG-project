using Creatures.Main;

namespace Creatures.BestiaryC1o8
{
    internal class TwigBlight : Creatures
    {
        readonly Dices dice = new();
        public TwigBlight()
        {
            Name = "Twig Blight";
            Type = pl;
            Size = s;
            Alignment = ne;
            HitPoints = 4 + dice.Roll(6) + 1;
            ArmorClass = 13;
            Speed = "20ft";
            Attributes = [6, 13, 12, 4, 8, 3];
            ChallengeLevel = "1/8";
            Experience = 25;
            DamageVulnerabilities = "fire";
            ConditionImmunities = "blinded, deafened";
            Skills = "Stealth +3";
            Senses = "blindsight 60ft (blind beyond this radius), passive Perception 9";
            Actions = [
                @"
Claws. Melee Weapon Attack: +3 to hit, reach 5 ft, one target.
Hit: 3 (1d4 + 1) piercing damage."
                ];
            Abilities = [
                @"
False Appearance. While the blight remains motionl ess, it is
indistingui shable from a dead shrub."
                ];
        }
    }
}
