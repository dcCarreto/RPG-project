using Base;

namespace BestiaryIndex.BestiaryC2
{
    internal class GnollPackLord : Creature
    {

        public GnollPackLord()
        {
            Name = "Gnoll Pack Lord";
            Type = CreatureTypes.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.ChaoticEvil;
            HitPoints = 49 + RollMultiple(8, 9) + 9;
            ArmorClass = 15;
            Speed = "30ft";
            AttributeValue = [16, 14, 13, 8, 11, 9];
            ChallengeLevel = "2";
            Experience = 450;
            Senses = "darkvision 60ft, passive Perception 10";
            Languages = "Gnoll";
            Actions = [
                @"
Multiattack. The gnoll makes two attacks, either with its glaive
or its lon gbow, and uses its Incite Rampage if it can.",
                @"
Bite. Melee Weapon Attack: +5 to hit, reach 5 ft., one creature.
Hit: 5 (1d4 + 3) piercing damage.",
                @"
Glaive. Melee Weapon Attack: +5 to hit, reach 10ft., one target.
Hit: 8 (1d10 + 3) slashing damage.",
                @"
Longbow. Ranged Weapon Attack: +4 to hit, range 1 50J600 ft .,
one target. Hit: 6 (1d8 + 2) piercing damage.",
                @"
Incite Rampage (Recharge 5- 6). One creature the gnoll can see
within 30 feet of itca n use its reaction to make a melee attack
if it can hear the gnoll and has the Rampage trait."
                ];
            Abilities = [
                @"
Rampage. When the gnoll reduces a creatu re to 0 hit points
with a melee attack on its turn , the gnoll can take a bonus
action to move up to half its speed and make a bite attack."
                ];
        }
    }
}
