using Base;

namespace BestiaryIndex.BestiaryC1o4
{
    internal class Goblin : Creature
    {

        public Goblin()
        {
            Name = "Goblin";
            Type = CreatureTypes.Humanoid;
            Size = Sizes.Small;
            Alignment = Alignments.NeutralEvil;
            HitPoints = 7 + RollMultiple(6, 2);
            AttributeValue = [8, 14, 10, 10, 8, 8];
            ArmorClass = 15;
            Speed = "30ft";
            Experience = 50;
            ChallengeLevel = "1/4";
            Skills = "Stealth +4";
            Senses = "darkvision 60ft, passive Perception 9";
            Languages = "Common, Goblin";
            Actions = [
                @"
Scimitar. Melee Weapon Attack: +4 to hit, reach 5ft, one target
Hit: 5 (1d6 + 2) slashing damage.",
                @"
Shortbow. Ranged Weapon Attack: +4 to hit, range 80/320ft, one target.
Hit: 5 (1d6 + 2) piercing damage."
                ];
            Abilities = [
                @"
Nimble Escape. The goblin can take the Disengage or Hide action as a
bonus action on each of its turns."
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Attacks =
                [
                new(ActionList.Scimitar, DamageTypes.Slashing, RangeTypes.Melee, "1d6 + 2"),
                new(ActionList.ShortBow, DamageTypes.Piercing, RangeTypes.Ranged, "1d6 + 2")
                ];
        }
    }
}
