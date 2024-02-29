using Creatures.Main;

namespace Creatures.BestiaryC1
{
    internal class GiantToad : Creatures
    {
        readonly Dices dice = new();
        public GiantToad()
        {
            Name = "Giant Toad";
            Type = ba;
            Size = m;
            Alignment = ud;
            HitPoints = 13 + dice.RollMultiple(8, 3);
            ArmorClass = 12;
            Speed = "10ft, fly 50ft";
            Attributes = [15, 13, 13, 2, 10, 3];
            ChallengeLevel = "1";
            Experience = 200;
            Senses = "darkvision 30ft, passive Perception 10";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 7 (1d10 + 2) piercing damage plus 5 (1d10) poison
damage, and the target is grappled (escape DC 13). Until this
grapple ends, the target is restrained, and the toad can't bite
another target.",
                @"
Swallow. The toad makes one bite attack against a Medium
or smaller target it is grappling. If the attack hits, the target
is swallowed, and the grapple ends. The swallowed target
is blinded and restrained, it has total cover against attacks
and other effects outside the toad, and it takes 10 (3d6) acid
damage at the start of each of the toad's turns. The toad can
have only one target swallowed at a time.
If the toad dies, a swallowed creature is no longer restrained
by it and can escape from the corpse using 5 feet of movement,
exiting prone."
                ];
            Abilities = [
                @"
Amphibious. The toad can breathe air and water.",
                @"
Standing Leap. The toad's long jump is up to 20 feet and its
high jump is up to 10 feet, with or without a running start."
                ];

        }
    }
}
