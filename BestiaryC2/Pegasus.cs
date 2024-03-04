namespace Creatures.BestiaryC2
{
    internal class Pegasus : CreatureAttributes
    {
       public Pegasus()
        {
            Name = "Pegasus";
            Type = ce;
            Size = l;
            Alignment = cg;
            HitPoints = 59 + RollMultiple(10, 7) + 21;
            ArmorClass = 12;
            Speed = "60ft, fly 90ft";
            Attributes = [18, 15, 16, 10, 15, 13];
            ChallengeLevel = "2";
            Experience = 450;
            SavingThrows = "Dexterity +4, Wisdom +4, Charisma +3";
            Skills = "Perception +6";
            Senses = "passive Perception 16";
            Languages = "understands Celestial, Common, Elvish and Sylvan but can`t speak";
            Actions = [
                @"
Hooves. Melee Weapon Attack: +6 to hit, reach 5 ft., one target.
Hit: 11 (2d6 + 4) bludgeoning damage."
                ];
        }
    }
}
