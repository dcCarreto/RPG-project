using Creatures.Main;

namespace Creatures.BestiaryC1
{
    internal class Spy : Creatures
    {
        readonly Dices dice = new();
        public Spy()
        {
            Name = "Spy";
            Type = hu;
            Size = m;
            Alignment = aa;
            HitPoints = 27 + dice.RollMultiple(8, 6);
            ArmorClass = 12;
            Speed = "30ft";
            Attributes = [10, 15, 10, 12, 14, 16];
            ChallengeLevel = "1";
            Experience = 200;
            Skills = "Deception +5, Insight +4, Investigation +5, Perception +6, Persuasion +5, Sleight of Hand +4, Stealth +4";
            Senses = "passive Perception 16";
            Languages = "any two languages";
            Actions = [
                @"
Multiattack. The spy makes two melee attacks.",
                @"
Shortsword. Melee Weapon Attack: +4 to hit, reach 5 ft. , one
target. Hit: 5 (1d6 + 2) piercing damage.",
                @"
Hand Crossbow. Ranged Weapon Attack: +4 to hit, range 30/120
ft., one target. Hit: 5 (1d6 + 2) piercing damage."
                ];
            Abilities = [
                @"
Cunning Action. On each of its turns, the spy can use a bonus
action to take the Dash, Disengage, or Hide action.",
                @"
Sneak Attack (1/Turn). Th e spy deals an extra 7 (2d6)
damage when it hit s a target with a weapon attack and
has advantage on the attack roll , or when the target is
within 5 feet of an ally of the spy that isn't incapacitated
and the spy does n't have di sadvantage on the
attack roll."
                ];
        }
    }
}
