namespace Creatures.BestiaryC1o4
{
    internal class Drow : Creature
    {

        public Drow()
        {
            Name = "Drow";
            Type = hu;
            Size = m;
            Alignment = ne;
            HitPoints = 13 + RollMultiple(8, 3);
            Attributes = [10, 14, 10, 11, 11, 12];
            ArmorClass = 15;
            Speed = "30ft";
            Experience = 50;
            ChallengeLevel = "1/4";
            Skills = "Perception +2, Stealth +4";
            Senses = "darkvision 120ft, passive Perception 12";
            Languages = "Elvish, Undercommon";
            Actions = [
                @"
Shortsword. Melee Weapon Attack: +4 to hit, reach 5ft, one target.
Hit 5 (1d6 + 2) piercing damage.",
                @"
Hand Crossbow. Ranged Weapon Attack: +4 to hit, range 30/120
ft., one target. Hit: 5 (1 6 + 2) piercing damage, and the
target must succeed on a DC 13 Constitutio.n saving throw or
be poisoned for 1 hour. If the saving throw fails by 5 or more,
the target is also unconscious while poisoned in this way. The
target wakes up if it takes damage or if another creature takes
an action to shake it awake."
                ];
            Abilities = [
                @"
Fey Ancestry. The drow has advantage on saving throws against
being charmed, and magic can't put the drow to sleep.",
                @"
Innate Spellcasting. The drew's spellcasting ability is Charisma
(spell save DC 11). It can innately cast the following spells,
requiring no material components:
At will: dancing lights
1fday each: darkness,faerie fire",
                @"
Sunlight Sensitivity. While in sunlight, the drow has
disadvantage on attack rolls, as well as on Wisdom
(Perception) checks that rely on sight."
                ];
        }
    }
}
