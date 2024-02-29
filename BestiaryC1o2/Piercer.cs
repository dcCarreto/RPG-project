using Creatures.Main;

namespace Creatures.BestiaryC1o2
{
    internal class Piercer : Creatures
    {
        readonly Dices dice = new();
        public Piercer()
        {
            Name = "Piercer";
            Type = mo;
            Size = m;
            Alignment = ud;
            HitPoints = 22 + dice.RollMultiple(8, 3) + 9;
            ArmorClass = 15;
            Speed = "5ft, climb 5ft";
            Attributes = [10, 13, 16, 1, 7, 3];
            ChallengeLevel = "1/2";
            Experience = 100;
            Skills = "Stealth +5";
            Senses = "blindsight 30ft, darkvision 60ft, passive Perception 8";
            Actions = [
                @"
Drop. Melee Weapon Attack: +3 to hit, one creature directly
underneath the piercer. Hit: 3 (1d6) piercing damage per 10
feet fallen, up to 21 (6d6) . Miss: The piercer takes half the
normal falling damage for the distance fallen."
                ];
            Abilities = [
                @"
False Appearance. While the piercer remains motionless on the
ceiling, it is indistinguishable from a normal stalactite.",
                @"
Spider Climb. The piercer can climb difficult surfaces,
including upside down on ceilings, without needing to make an
ability check."
                ];
        }
    }
}
