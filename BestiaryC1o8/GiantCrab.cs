namespace Creatures.BestiaryC1o8
{
    internal class GiantCrab : Creatures
    {
        readonly Dices dice = new();
        public GiantCrab()
        {
            Name = "Giant Crab";
            Type = ba;
            Size = m;
            Alignment = ud;
            HitPoints = 13 + dice.RollMultiple(dice.d8, 3);
            Attributes = [13, 15, 11, 1, 9, 3];
            ArmorClass = 15;
            Speed = "30ft, swim 30ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Skills = "Stealth +4";
            Senses = "blindsight 30ft, passive Perception 9";
            Actions = [
                @"
 Claw. Melee Weapon Attack: +3 to hit, reach 5ft, one target.
 Hit: 4 (1d6 + 1) bludgeoning damage, and the target is 
 grappled (escape DC 11). The crab has two claws, each of
 which can grapple only one target."
                ];
            Abilities = [
                @"               
Amphibious. The crab can breath air and water."
            ];
        }
    }
}