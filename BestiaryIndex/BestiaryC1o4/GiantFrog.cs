using Base;

namespace BestiaryIndex.BestiaryC1o4
{
    internal class GiantFrog : Creature
    {

        public GiantFrog()
        {
            Name = "Giant Frog";
            Type = CreatureTypes.Beast;
            Size = Sizes.Medium;
            Alignment = Alignments.Unaligned;
            HitPoints = 18 + RollMultiple(8, 4);
            ArmorClass = 11;
            Speed = "30ft, swim 30ft";
            AttributeValue = [12, 13, 11, 2, 10, 3];
            ChallengeLevel = "1/4";
            Experience = 50;
            Skills = "Perception +2, Stealth +3";
            Senses = "darkvision 30ft, passive Perception 12";
            Actions = [
                @"
Bite. Melee Weapon Attack: +3 to hit, reach 5 ft, one target.
Hit: 4 (1d6 + 1) piercing damage, and the target is grappled
(escape DC 11). Until this grapple ends, the target is restrained,
and the frog can't bite another target.",
                @"
Swallow. The frog makes one bite attack against a Small or
smaller target it is grappling. If the attack hits, the target is
swal lowed , and the grapple ends. The swa llowed target is
blinded and restrained, it has total cover against attacks and
other effects outside the frog, and it takes 5 (2d4) acid damage
at the start of each of the frog's turns. The frog can have only
one target swallowed at a time.
If the frog dies, a swallowed creature is no longer restr.ained
by it and can escape from the corpse using 5 feet of movement,
exiting prone."
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Abilities = [
                @"
Amphibious. The frog can breathe air and water.",
                @"
Standing Leap. The frog's long jump is up to 20 feet and its
high jump is up to 10 feet, with or without a running start."
                ];
            Attacks =
                [
                new(ActionList.Bite, DamageTypes.Piercing, RangeTypes.Melee, "1d6 + 1")
                ];
        }
    }
}
