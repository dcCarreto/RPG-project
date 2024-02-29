using Creatures.Main;

namespace Creatures.BestiaryC1o2
{
    internal class Sahuagin : Creatures
    {
        readonly Dices dice = new();
        public Sahuagin()
        {
            Name = "Sahuagin";
            Type = hu;
            Size = m;
            Alignment = le;
            HitPoints = 22 + dice.RollMultiple(8, 4) + 4;
            ArmorClass = 12;
            Speed = "30ft, swim 40ft";
            Attributes = [13, 11, 12, 12, 13, 9];
            ChallengeLevel = "1/2";
            Experience = 100;
            Skills = "Perception +5";
            Senses = "darkvision 120ft, passive Perception 15";
            Languages = "Sahuagin";
            Actions = [
                @"
Multiattack. The sahuagin makes two melee attacks: one with
its bite and one with its claws or spear.",
@"
Bite. Melee Weapon Attack: +3 to hit, reach 5 ft., one target.
Hit: 3 (1d4 + 1) piercing damage.",
@"
Claws. Melee Weapon Attack: +3 to hit, reach 5 ft., one target.
Hit: 3 (1d4 + 1) slashing damage.",
@"
Spear. Melee or Ranged Weapon Attack: +3 to hit, reach 5 ft. or
range 20f60 ft ., one target. Hit: 4 (1d6 + 1) piercing damage, or
5 (ld8 + 1) piercing damage if used with two hands to make a
melee attack."
                ];
            Abilities = [
                @"
Blood Frenzy. The sahuagin has advantage on melee attack
rolls against any creature that doesn't have all its hit points.",
@"
Limited Amphibiousness. The sahuagin can breathe air and
water, but it needs to be submerged at least once every 4 hours
to avoid suffocating.",
@"
Shark Telepathy. The sahuagin can magically command any
shark within 120 feet of it, using a limi ted telepathy."
                ];
        }
    }
}
