using Creatures.Main;

namespace Creatures.BestiaryC1
{
    internal class YuanTiPureblood : Creatures
    {
        readonly Dices dice = new();
        public YuanTiPureblood()
        {
            Name = "Yuan-Ti Pureblood";
            Type = hu;
            Size = m;
            Alignment = ne;
            HitPoints = 40 + dice.RollMultiple(8, 9);
            ArmorClass = 11;
            Speed = "30ft";
            Attributes = [11, 12, 11, 13, 12, 14];
            ChallengeLevel = "1";
            Experience = 200;
            DamageImmunities = "poison";
            ConditionImmunities = "poisoned";
            Skills = "Deception +6, Perception +3, Stealth +3";
            Senses = "darkvision 60ft, passive Perception 13";
            Languages = "Abyssal, Common, Draconic";
            Actions = [
                @"
Multiattack. The yuan-ti makes two melee attacks.",
                @"
Scimitar. Melee Weapon Attack: +3 to hit, reach 5 ft., one
target. Hit: 4 (1d6 + 1) slashing damage.",
                @"
Shortbow. Ranged Weapon Attack: +3 to hit, range 80/320
ft ., one target. Hit: 4 (1d6 + 1) piercing damage plus 7 (2d6)
poison damage."
                ];
            Abilities = [
                @"
Innate Spellcasting. The yuan-ti's spellca sting abi lity is
Charisma (spell save DC 12). The yuan-ti can innately cast the
following spel ls, requiring no material components:
At wi ll: animal friendship (snakes only)
3Jday each: poison spray, suggestion",
                @"
Magic Resistance. The yuan·ti has advantage on saving throws
aga inst spells and other magical effects."
                ];
        }
    }
}
