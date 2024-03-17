namespace Creatures.BestiaryC1
{
    internal class FireSnake : Creature
    {

        public FireSnake()
        {
            Name = "Fire Snake";
            Type = Types.Elemental;
            Size = Sizes.Medium;
            Alignment = Alignments.NeutralEvil;
            HitPoints = 22 + RollMultiple(8, 5);
            ArmorClass = 14;
            Speed = "30ft";
            Attributes = [12, 14, 11, 7, 10, 8];
            ChallengeLevel = "1";
            Experience = 200;
            DamageVulnerabilities = "cold";
            DamageResistances = "bludgeoning, piercing, and slashing from nonmagical weapons";
            DamageImmunities = "fire";
            Senses = "darkvision 60ft, passive Perception 10";
            Languages = "understands Ignan but can`t speak";
            Actions = [
                @"
Multiattack. The snake makes two attacks: one with its bite
and one with its tail.",
                @"
Bite. Melee Weapon Attack: +3 to hit, reach 5 ft., one ta rget.
Hit: 3 (1d4 + 1) piercing damage plus 3 (1d6) fire damage.",
                @"
Tail. Melee Weapon Attack: +3 to hit, reach 5 ft., one target. Hit:
3 (1d4 + 1) bludgeoning damage plus 3 (1d6) fire damage."
                ];
            Abilities = [
                @"
Heated Body. A creature that touches the snake or hits it with a
melee attack while within 5 feet of it takes 3 (1d6) fire damage."
                ];
        }
    }
}
