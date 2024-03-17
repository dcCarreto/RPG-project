namespace Creatures.BestiaryC2
{
    internal class Plesiosaurus : Creature
    {

        public Plesiosaurus()
        {
            Name = "Plesiosaurus";
            Type = Types.Beast;
            Size = Sizes.Large;
            Alignment = Alignments.Unaligned;
            HitPoints = 68 + RollMultiple(10, 8) + 24;
            ArmorClass = 13;
            Speed = "20ft, swim 40ft";
            Attributes = [18, 15, 16, 2, 12, 5];
            ChallengeLevel = "2";
            Experience = 450;
            Skills = "Perception +3, Stealth +4";
            Senses = "passive Perception 13";
            Actions = [
                @"
Bite. Melee Weapon Attack: +6 to hit, reach 10 ft. , one target.
Hit: 14 (3d6 + 4) piercing damage."
                ];
            Abilities = [
                @"
Hold Breath. The plesiosaurus can hold its breath for 1 hour."
                ];
        }
    }
}
