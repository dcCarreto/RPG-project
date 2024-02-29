using Creatures.Main;

namespace Creatures.BestiaryC1
{
    internal class Bugbear : Creatures
    {
        readonly Dices dice = new();
        public Bugbear()
        {
            Name = "Bugbear";
            Type = hu;
            Size = m;
            Alignment = ce;
            HitPoints = 27 + dice.RollMultiple(8, 5) + 5;
            ArmorClass = 16;
            Speed = "30ft";
            Attributes = [15, 14, 13, 8, 11, 9];
            ChallengeLevel = "1";
            Experience = 200;
            Skills = "Stealth +6, Survival +2";
            Senses = "darkvision 60ft, passive Perception 10";
            Languages = "Common, Goblin";
            Actions = [
                @"
Morningstar. Melee Weapon Attack: +4 to hit, reach 5 ft. , one
target. Hit: ll (2d8 + 2) piercing damage.",
                @"
javelin. Melee or Ranged Weapon Attack: +4 to hit, reach 5 ft. or
range 30/1 20 ft., one target. Hit: 9 (2d6 + 2) piercing damage
in melee or 5 (1d6 + 2) piercing damage at range."
                ];
            Abilities = [
                @"
Brute. A melee weapon deals one extra die of its damage when the
bugbear hits with it (included in the attack).",
                @"
Surprise Attack. If the bugbear surprises a creature and hits it
with an attack during the first round of combat, the target takes
an extra 7 (2d6) damage from the attack."
                ];
        }
    }
}
