using Creatures.Main;

namespace Creatures.BestiaryC1
{
    internal class DeathDog : Creatures
    {
        readonly Dices dice = new();
        public DeathDog()
        {
            Name = "Death Dog";
            Type = mo;
            Size = m;
            Alignment = ne;
            HitPoints = 39 + dice.RollMultiple(8, 6) + 12;
            ArmorClass = 12;
            Speed = "40ft";
            Attributes = [15, 14, 14, 3, 13, 6];
            ChallengeLevel = "1";
            Experience = 200;
            Skills = "Perception +5, Stealth + 4";
            Senses = "darkvision 120ft, passive Perception 15";
            Actions = [
                @"
Multiattack. The dog makes two bite attacks .",
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 5 (1 6 + 2) piercing damage. lfthe target is a creature, it
must succeed on a DC 12 Constitution saving throw against
disease or become poisoned until the disease is cured. Every 24
hours that elapse, the creature must repeat the saving throw,
reducing its hit point maximum by 5 (ldlO) on a failure. This
reduction lasts until the disease is cured. The creature dies if
the disease reduces its hit point maximum to 0."
                ];
            Abilities = [
                @"
Two-Headed. The dog has advantage on Wisdom (Perception)
checks and on saving throws against being blinded, charmed,
deafened, frightened, stunned, or knocked unconscious."
                ];
        }
    }
}
