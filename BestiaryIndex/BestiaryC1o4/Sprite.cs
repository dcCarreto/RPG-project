using Base;

namespace BestiaryIndex.BestiaryC1o4
{
    internal class Sprite : Creature
    {

        public Sprite()
        {
            Name = "Sprite";
            Type = CreatureTypes.Fey;
            Size = Sizes.Tiny;
            Alignment = Alignments.NeutralGood;
            HitPoints = 2 + Roll(4);
            ArmorClass = 15;
            Speed = "10ft, fly 40ft";
            AttributeValue = [3, 18, 10, 14, 13, 11];
            ChallengeLevel = "1/4";
            Experience = 50;
            Skills = "Perception +#, Stealth +8";
            Senses = "passive Perception 13";
            Languages = "Common, Elvish, Sylvian";
            Actions = [
                @"
Longsword. Melee Weapon Attack: +2 to hit, reach 5 ft, one
target. Hit: 1 slashing damage.",
                @"
Shortbow. Ranged Weapon Attack: +6 to hit, range 40/1 60
ft, one target. Hit: 1 piercing damage, and the ta rget must
succeed on a DC 10 Constitution saving throw or become
poisoned for 1 minute. If its saving th row result is 5 or lower,
the poisoned target fa lls unconscious for the same duration,
or until it takes damage or another creature takes an action to
shake it awake.",
                @"
Heart Sight. The sprite touches a creature and magically knows
the creatu re's current emotional state. If the target fails a DC
10 Charisma saving throw, the sprite also knows the creature's
alignment. Celestials, fiends, and undead automatically fail the
saving throw.",
                @"
Invisibility. The sprite magically turns invisible until it
attacks or casts a spell , or until its concentration ends (as if
concentrating on a spell). Any equipment the sprite wears or
carries is invisible with it."
                ];
            Attacks =
                [
                new(ActionList.Longsword, DamageTypes.Slashing, RangeTypes.Melee, "1d1"),
                new(ActionList.ShortBow, DamageTypes.Piercing, RangeTypes.Ranged, "1d1")
                ];

        }
    }
}
