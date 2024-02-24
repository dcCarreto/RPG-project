namespace Creatures.BestiaryC1o4
{
    internal class KuoToa: Creatures
    {
        readonly Dices dice = new();
        public KuoToa()
        {
            Name = "Kuo-Toa";
            Type = hu;
            Size = m;
            Alignment = ne;
            HitPoints = 18 + dice.RollMultiple(dice.d8, 4);
            Attributes = [13, 10, 11, 11, 10, 8];
            ArmorClass = 13;
            Speed = "30ft, swim 30ft";
            Experience = 50;
            ChallengeLevel = "1/4";
            Skills = "Perception +4";
            Senses = "darkvision 120ft, passive Perception 14";
            Languages = "Undercommon";
            Actions = [
                @"
Bite. Melee Weapon Attack: +3 to hit, reach 5ft, one target.
Hit: 3 (1d4 + 1) piercing damage.",
                @"
Spear. Melee or Ranged Weapon Attack: +3 to hit, reach 5ft
or range 20/60ft, one target.
Hit: 4 (1d6 +1) piercing damage, or 5 (1d8 +1) piercing damage
if used  with two hands to make a melee attack.",
                @"
Net. Ranged Weapon Attack: +3 to hit, range 5/15ft, one Large
or smaller creature.
Hit: The target is restrained. A creature can use its action
to make a DC 10 Strength check to free itself or another
creature in a net, ending the effect on a success.
Dealing 5 slashing damage to the net (AC 10) frees the target
without harming it and destroys the net."
                ];
            Reactions = @"
Stick Shield. When a creature misses the kuo-toa with a melee
weapon attack, the kuo-toa uses its sticky shield to catch the
weapon. The attacker must succeed on a DC 11 Strength saving
throw, or the weapon becomes stuck to the kuo-toa's shield.
If the weapon can't or won't let go of the weapon, the wielder
is grappled while the weapon is stuck.
While stuck, the weapon can't be used. A creature can pull the
wapon free by taking an action to make a DC 11 Strength check
and succeeding.";
            Abilities = [
            @"
Amphibious. the kuo-toa can breath air and water.",
            @"
Otherwordly Perception. The kuo-toa can sense the presense
of any creature within 30ft of it that is invisible or on the
Etheral Plane. It can pinpoint such a creature that is moving.",
            @"
Slippery. The kuo-toa has advantage on abilty checks and saving
throws made to escape a grapple.",
            @"
Sunlight Sensivity. While in sunlight, the kuo-toa has disavantage
on attack rolss, as well as on Wisdom (Perception) checks that 
rely on sight."];
            
        }
    }
}
