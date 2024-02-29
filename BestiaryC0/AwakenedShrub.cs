using Creatures.Main;

namespace Creatures.BestiaryC0
{
    internal class AwakanedShrub : Creatures
    {
        readonly Dices dice = new();
        public AwakanedShrub()
        {
            Name = "Awakaned Shrub";
            Type = pl;
            Size = s;
            Alignment = ud;
            HitPoints = 10 + (dice.Roll(6) + dice.Roll(6) + dice.Roll(6));
            Attributes = [3, 8, 11, 10, 10, 6];
            ArmorClass = 9;
            Speed = "20ft";
            Experience = 10;
            ChallengeLevel = "0";
            DamageVulnerabilities = "fire";
            DamageResistances = "piercing";
            Senses = "passive Perception 10";
            Languages = "one language known by its creator";
            Actions = [
                @"
Rake. Melee Weapon Attack: +1 to hit, reach 5 ft, one target.
Hit: 1 (1d4- 1), slashing damage."
                ];
            Abilities = [
                @"
False Appearance. While the shrub remains motionless, it is indistinguishable from a normal shrub."
                ];

        }
    }
}
