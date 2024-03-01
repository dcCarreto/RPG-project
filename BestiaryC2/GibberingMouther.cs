namespace Creatures.BestiaryC2
{
    internal class GibberingMouther : Creatures
    {

        public GibberingMouther()
        {
            Name = "Gibbering Mouther";
            Type = ab;
            Size = m;
            Alignment = n;
            HitPoints = 67 + RollMultiple(8, 9) + 27;
            ArmorClass = 9;
            Speed = "10ft, swim 10ft";
            Attributes = [10, 8, 16, 3, 10, 6];
            ChallengeLevel = "2";
            Experience = 450;
            ConditionImmunities = "prone";
            Senses = "darkvision 60ft, passive Perception 10";
            Actions = [
                @"
Multiattack. The gibbering mouther makes one bite attack and,
if it can, uses its Blinding Spittle.",
                @"
Bites. Melee Weapon Attack: +2 to hit, reach 5 ft., one creature.
Hit: 17 (5d6) piercing damage. If the target is Medium or
smaller, it must succeed on a DC 10 Strength saving throw or
be knocked prone. lfthe target is killed by this damage, it is
absorbed into the mouther.",
                @"
Blinding Spittle (Recharge 5-6). The mouther spits a chemical
glob at a point it can see within 15 feet of it. The glob explodes
in a blinding flash of light on impact. Each creature within 5
feet of the flash must succeed on a DC 13 Dexterity saving
throw or be blinded until the end of the mouther's next turn."
                ];
            Abilities = [
                @"
Aberrant Ground. The ground in a 10-foot radius around the
mouther is doughlike difficult terrain. Each creature that starts
its turn in that area must succeed on a DC 10 Strength saving
throw or have its speed reduced to 0 until the start of its
next turn.",
@"
Gibbering. The mouther babbles incoherently while it can
see any creature and isn't incapacitated. Each creature that
starts its turn within 20 feet of the mouther and can hear the
gibbering must succeed on a DC 10 Wisdom saving throw.
On a failure, the creature can't take reactions until the start of
its next turn and rolls a d8 to determine what it does du~ing
its turn. On a 1 to 4, the creature does nothing. On a 5 or 6,
the creature takes no action or bonus action and uses all its
movement to move in a randomly determined direction. On a
7 or 8, the creature makes a melee attack against a randomly
determined creature within its reach or does nothing if it can't
make such an attack."
                ];
        }
    }
}
